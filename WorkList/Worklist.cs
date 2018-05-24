using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace WorkList
{
    public partial class Worklist : Form
    {
        static bool powerOn = true;
        static String datetimeFormat = "yyyy-MM-dd HH:mm:ss";
        public static String conString = "Data Source=(localdb)\\MSSQLLOCALDB;Initial Catalog=Pomodoro;Integrated Security=True";
        SqlConnection con = null;
        SqlDataAdapter sda = null;
        SqlCommand cmd = null;
        SqlDataReader sdr = null;
        static List<Task> lstTasks = new List<Task>();
        static Dictionary<int, Task> dictTasksCopyForModification = new Dictionary<int, Task>();
        static Queue<Task> queueTasksReachedDeadline = new Queue<Task>();

        public Worklist()
        {
            InitializeComponent();
            lstTasks = getTasks();
            populateTable();

        }

        private void populateTable()
        {

            int tableSize = lstTasks.Count;
            RowStyle temp = tableLayoutPanel.RowStyles[0];
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowCount = 1;
            for (int row = 0; row < tableSize; row++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
                tableLayoutPanel.RowCount++;

                Task obj = lstTasks.ElementAt(row);
                createTableRow(obj, row);
            }
            createEmptyTableRow();
        }

        private void modifyDictTasksCopyForModification(Task obj)
        {
            if(dictTasksCopyForModification.ContainsKey(obj.id))
            {
                dictTasksCopyForModification[obj.id] = obj;
            }
            else
            {
                dictTasksCopyForModification.Add(obj.id, obj);
            }
            /*foreach (var item in dictTasksCopyForModification)
            {
                MessageBox.Show(item.Key + " " + item.Value.task);
            }*/
        }

        private void createTableRow(Task obj, int row)
        {
            int taskId = obj.id;

            CheckBox c = new CheckBox();
            c.Checked = obj.isDone;
            c.AutoSize = true;
            c.Dock = DockStyle.Fill;
            tableLayoutPanel.Controls.Add(c, 0, row);
            c.CheckStateChanged += (sender, e) =>
            {
                obj.isDone = c.Checked;
                modifyDictTasksCopyForModification(obj);
            };

            TextBox t = new TextBox();
            //t.Margin = new Padding(0);
            t.Font = new Font("Century Gothic", 11, FontStyle.Regular);
            t.Text = obj.task;
            if (t.Text == String.Empty)
            {
                t.ForeColor = System.Drawing.Color.Gray;
                t.Text = "add to do..";
            }
            //t.BorderStyle = BorderStyle.None;
            t.AutoSize = true;
            t.Dock = DockStyle.Fill;
            tableLayoutPanel.Controls.Add(t, 1, row);
            t.TextChanged += (sender, e) =>
            {
                t.ForeColor = new System.Drawing.Color();
                obj.task = t.Text;
                modifyDictTasksCopyForModification(obj);
            };
            t.Enter += (sender, e) =>
            {
                if (t.Text == "add to do..")
                    t.Text = "";
            };
            t.Leave += (sender, e) =>
            {
                if (t.Text == String.Empty)
                {
                    t.ForeColor = System.Drawing.Color.Gray;
                    t.Text = "add to do..";
                }
            };

            DateTimePicker datePicker = new DateTimePicker();
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Size = new Size(77, 20);
            datePicker.Value = obj.dt;
            datePicker.Font = new Font("Century Gothic", 9, FontStyle.Regular);
            datePicker.Dock = DockStyle.Top;

            DateTimePicker timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(77, 20);
            timePicker.Value = obj.dt;
            timePicker.Font = new Font("Century Gothic", 9, FontStyle.Regular);
            timePicker.Dock = DockStyle.Top;

            datePicker.ValueChanged += (sender, e) =>
            {
                obj.dt = getDateTime(datePicker.Value, timePicker.Value);
                modifyDictTasksCopyForModification(obj);
            };
            timePicker.ValueChanged += (sender, e) =>
            {
                obj.dt = getDateTime(datePicker.Value, timePicker.Value);
                modifyDictTasksCopyForModification(obj);
            };

            tableLayoutPanel.Controls.Add(datePicker, 2, row);
            tableLayoutPanel.Controls.Add(timePicker, 3, row);

            PictureBox delPicbox = new PictureBox();
            delPicbox.AutoSize = true;
            delPicbox.Image = imageList1.Images[1];
            delPicbox.Dock = DockStyle.Fill;
            delPicbox.Click += (sender, e) =>
            {
                deleteTask(obj);
                lstTasks.Remove(obj);
                tableLayoutPanel.RowCount--;
                MessageBox.Show(obj.task+" task deleted!");
                buttonRefresh.PerformClick();
            };
            tableLayoutPanel.Controls.Add(delPicbox, 4, row);

            PictureBox pomodoroPicbox = new PictureBox();
            pomodoroPicbox.AutoSize = true;
            pomodoroPicbox.Image = imageList1.Images[2];
            pomodoroPicbox.Dock = DockStyle.Fill;
            pomodoroPicbox.Click += (sender, e) =>
            {
                Pomodoro p = new Pomodoro(obj);
                p.Visible = true;
                buttonRefresh.PerformClick();
            };
            tableLayoutPanel.Controls.Add(pomodoroPicbox, 5, row);
        }

        private void createEmptyTableRow()
        {
            Task t = new Task();
            con = new SqlConnection(conString);
            String sql = "select ID from Tasks"; //tasksIDseq is a SQL Sequence
            con.Open();
            cmd = new SqlCommand(sql, con);
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
                t.id = sdr.GetInt32(0);
            sdr.Close();
            con.Close();
            createTableRow(t, tableLayoutPanel.RowCount - 1);
        }

        private List<Task> getTasks()
        {
            lstTasks.Clear();

            SqlConnection con = new SqlConnection(conString);
            String sql = "select [ID],[TASK],[IS_TASK_DONE],[DELAY_REASON],[TASK_COMPLETION_DATETIME],[TOTAL_TASKTIME],[POMODOROS] from tasks where convert(date, task_completion_datetime) = convert (date, GETDATE())";
            con.Open();
            cmd = new SqlCommand(sql, con);
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Task t = new Task();
                t.id = sdr.GetInt32(0);
                t.task = sdr.GetString(1);
                t.isDone = (sdr.GetString(2).Equals("T")) ? true : false;
                t.dt = sdr.GetDateTime(4);
                t.totalTaskTime = sdr.GetTimeSpan(5);
                t.pomodoros = sdr.GetInt32(6);
                lstTasks.Add(t);
            }
            con.Close();
            return lstTasks;
        }

        private DateTime getDateTime(DateTime date, DateTime time)
        {
            return new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);
        }

        private void insertIntoDBAndList(Task t)
        {
            //con = new SqlConnection(conString);
            con.Open();

            int id = t.id;
            String task = t.task;
            char done = (t.isDone) ? 'T' : 'F';
            DateTime dt = t.dt;
            TimeSpan totaltime = t.totalTaskTime;
            int pomoCount = t.pomodoros;

            String sql = "insert into Tasks ([ID],[TASK],[IS_TASK_DONE],[DELAY_REASON],[TASK_COMPLETION_DATETIME],[TOTAL_TASKTIME],[POMODOROS]) values (" + id + ", '" + task + "', '" + done + "', '', '" + dt + "','" + totaltime +"','" +pomoCount+"')";
            sda = new SqlDataAdapter(sql, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            //MessageBox.Show("insertIntoDBAndList() adding.." + t.task);
            //lstTasks.Add(t);
            lstTasks = getTasks();
            populateTable();
            //MessageBox.Show("inserted & list updated!!");
        }

        private int updateTask(Task t)
        {
            int update = 0;
            char isDone = (t.isDone) ? 'T' : 'F';
            String sql = "update tasks set task='"+t.task+ "', is_Task_Done='" + isDone + "', task_completion_datetime='" + t.dt + "' where id=" + t.id;
            con.Open();
            sda = new SqlDataAdapter(sql, con);
            update = sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            return update;
        }

        private void updateCheckBox(Task t)
        {
            char isDone = (t.isDone) ? 'T' : 'F';
            String sql = "update tasks set is_Task_Done='" + isDone + "' where id=" + t.id;
            con.Open();
            sda = new SqlDataAdapter(sql, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            //MessageBox.Show("checkbox updated!!");
        }

        private void updateTextBox(Task t)
        {
            String sql = "update tasks set task='" + t.task + "' where id=" + t.id;
            con.Open();
            sda = new SqlDataAdapter(sql, con);
            int recordExists = sda.SelectCommand.ExecuteNonQuery();

            if (recordExists == 0)
                insertIntoDBAndList(t);
            con.Close();
            //MessageBox.Show("textbox updated!!");
        }

        private void updateDelayReason(Task t)
        {
            String sql = "update tasks set delay_reason='" + t.delayReason + "' where id=" + t.id;
            con.Open();
            sda = new SqlDataAdapter(sql, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            //MessageBox.Show("delay reason updated!!");
        }

        private void updateDateTime(Task t)
        {
            String sql = "update tasks set task_completion_datetime='" + t.dt + "' where id=" + t.id;
            con.Open();
            sda = new SqlDataAdapter(sql, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            //MessageBox.Show("Datetime updated!!");
        }

        private void deleteTask(Task t)
        {
            String sql = "delete from tasks where id=" + t.id;
            con.Open();
            sda = new SqlDataAdapter(sql, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            //MessageBox.Show("Deleted!!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //con = new SqlConnection(conString);
            labelToday.Text = "Today\n";
            labelToday.Text += System.DateTime.Now.DayOfWeek + System.DateTime.Now.ToString(", dd MMMM");

            Thread t = new Thread(() => checkForTaskDeadlines());
            t.Start();
            t = new Thread(() => handleReachedDeadlineTasks());
            t.Start();
            
        }

        private void checkForTaskDeadlines()
        {
            while (powerOn)
            {
                //MessageBox.Show("checkForTaskDeadlines() lstTasks elements" + itrList());
                List<Task> lst = getTasks();
                Thread.Sleep(1000);
                foreach (Task obj in lst)
                {
                    //MessageBox.Show("-->"+obj.task);
                    String taskDeadline = obj.dt.ToString(datetimeFormat);
                    String currentTime = System.DateTime.Now.ToString(datetimeFormat);
                    if (taskDeadline == currentTime && !obj.isRead)
                    {
                        //MessageBox.Show("added " + obj.task + "isRead " + obj.isRead);
                        obj.isRead = true;
                        queueTasksReachedDeadline.Enqueue(obj);
                        //MessageBox.Show("checkForTaskDeadlines()enqueued.. " + obj.task+" :: "+itrQueue());
                        //MessageBox.Show("added "+obj.task+ "isRead "+obj.isRead);
                    }
                }
            }
        }
        private string itrList()
        {
            string str = "";
            foreach (var item in lstTasks)
            {
                str += item.task + " ";
            }
            return str;
        }

        private string itrQueue()
        {
            string str = "";
            foreach (var item in queueTasksReachedDeadline)
            {
                str += item.task + " ";
            }
            return str;
        }
        private void handleReachedDeadlineTasks()
        {
            Task t = null;
            while (powerOn)
            {
                if (queueTasksReachedDeadline.Count > 0)
                {
                    t = queueTasksReachedDeadline.Dequeue();
                    //MessageBox.Show("handleReachedDeadlineTasks() ->>" + itrQueue()+"<<-");
                    DialogResult rs = MessageBox.Show("Is the task '" + t.task + "' completed?", "Done?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        t.isDone = true;
                        //MessageBox.Show("done marked " + t.task);
                        updateCheckBox(t);
                        //populateTable();
                    }

                    else if (rs == DialogResult.No)
                    {
                        t.delayReason = Interaction.InputBox("Any specific reason for the delay?", "Information", "", -1, -1);
                        updateDelayReason(t);
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            powerOn = false;
        }

        private void buttonToDoList_Click(object sender, EventArgs e)
        {
            panelHistory.Visible = false;
            panelToDoList.Visible = true;
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            panelToDoList.Visible = false;
            panelHistory.Visible = true;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            String selectedDate = dateTimePickerHistory.Value.ToShortDateString();
            String sql = "select [TASK],[TASK_COMPLETION_DATETIME],[IS_TASK_DONE],[DELAY_REASON],[TOTAL_TASKTIME],[POMODOROS] from Tasks where convert (date, task_completion_datetime) = '" + selectedDate + "'";
            con.Open();
            cmd = new SqlCommand(sql, con);
            sdr = cmd.ExecuteReader();
            dataGridViewHistory.Rows.Clear();
            while (sdr.Read())
            {
                dataGridViewHistory.Rows.Add(sdr.GetString(0), sdr.GetDateTime(1), sdr.GetString(2), sdr.GetString(3), sdr.GetTimeSpan(4), sdr.GetInt32(5));
            }
            con.Close();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            String sql = "SELECT [TASK],[TASK_COMPLETION_DATETIME],[IS_TASK_DONE],[DELAY_REASON],[TOTAL_TASKTIME],[POMODOROS] FROM Tasks ";
            con.Open();
            cmd = new SqlCommand(sql, con);
            sdr = cmd.ExecuteReader();
            dataGridViewHistory.Rows.Clear();
            while (sdr.Read())
            {
                dataGridViewHistory.Rows.Add(sdr.GetString(0), sdr.GetDateTime(1), sdr.GetString(2), sdr.GetString(3), sdr.GetTimeSpan(4), sdr.GetInt32(5));
            }
            con.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            foreach (var item in dictTasksCopyForModification)
            {
                int updateCount = updateTask(item.Value);
                if (updateCount == 0)
                    insertIntoDBAndList(item.Value);
            }
            dictTasksCopyForModification.Clear();
            MessageBox.Show("Task changes saved!");
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            populateTable();
        }
    }

}
