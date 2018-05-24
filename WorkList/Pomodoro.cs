using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkList
{
    public partial class Pomodoro : Form
    {
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer stopWatchtimer;
        private int pomodorocunter = 0;
        private bool start = false;
        private bool isBreaktime = false;
        private bool startStopWatch = false;
        private int worktime;
        private int sessionsSW = 0;
        private int stopWatchTime;
        private int shortbreak;
        private int longbreak;

        private Task currentTask;

        public Pomodoro()
        {
            InitializeComponent();

            DBUtility.connectDB();
            getSettingFromDB();

            updateSetting();
        }

        public Pomodoro(Task t) : this()
        {
            currentTask = t;
            lblPomodoroCount.Text = "Today | Pomodoros: " + currentTask.pomodoros;

            lblTask.Text = currentTask.task;
            lblTaskS.Text = currentTask.task;
            lblTaskAddtime.Text = currentTask.task;

            lblTotalTime.Text = "Total task time: " + currentTask.totalTaskTime;
            lblTotalTimeS.Text = "Total task time: " + currentTask.totalTaskTime;
            lblTotalTaskTimeAddTime.Text = "Total task time: " + currentTask.totalTaskTime;

        }

        private void getSettingFromDB()
        {
            DBUtility.cmd = new SqlCommand("SELECT [Value] FROM [Pomodoro].[dbo].[PomodoroSettings] WHERE [Field] = 'workTimeMinutes'", DBUtility.con);
            DBUtility.reader = DBUtility.cmd.ExecuteReader();
            while (DBUtility.reader.Read())
            {
                Timer.workTimeMinutes = /*60 **/ DBUtility.reader.GetInt32(0);
                if (Timer.workTimeMinutes == 0)
                {
                    Timer.workTimeMinutes = 60 * 60 * 25; //Default
                    updateSettingToDB(0);
                }
            }
            DBUtility.reader.Close();

            DBUtility.cmd = new SqlCommand("SELECT [Value] FROM [Pomodoro].[dbo].[PomodoroSettings] WHERE [Field] = 'shortBreakTimeMinutes'", DBUtility.con);
            DBUtility.reader = DBUtility.cmd.ExecuteReader();
            while (DBUtility.reader.Read())
            {
                Timer.shortBreakTimeMinutes = DBUtility.reader.GetInt32(0);
                if (Timer.workTimeMinutes == 0)
                {
                    Timer.shortBreakTimeMinutes = 60 * 60 * 5; //Default
                    updateSettingToDB(1);
                }
            }
            DBUtility.reader.Close();

            DBUtility.cmd = new SqlCommand("SELECT [Value] FROM [Pomodoro].[dbo].[PomodoroSettings] WHERE [Field] = 'longBreakTimeMinutes'", DBUtility.con);
            DBUtility.reader = DBUtility.cmd.ExecuteReader();
            while (DBUtility.reader.Read())
            {
                Timer.longBreakTimeMinutes = DBUtility.reader.GetInt32(0);
                if (Timer.workTimeMinutes == 0)
                {
                    Timer.longBreakTimeMinutes = 60 * 60 * 15; //Default
                    updateSettingToDB(2);
                }
            }
            DBUtility.reader.Close();

            DBUtility.cmd = new SqlCommand("SELECT [Value] FROM [Pomodoro].[dbo].[PomodoroSettings] WHERE [Field] = 'longBreakInterval'", DBUtility.con);
            DBUtility.reader = DBUtility.cmd.ExecuteReader();
            while (DBUtility.reader.Read())
            {
                Timer.longBreakInterval = DBUtility.reader.GetInt32(0);
                if (Timer.workTimeMinutes == 0)
                {
                    Timer.longBreakInterval = 4; //Default
                    updateSettingToDB(3);
                }
            }
            DBUtility.reader.Close();

            updateComboBoxSetting();


        }

        private void updateComboBoxSetting()
        {
            cbWorktime.SelectedItem = Timer.workTimeMinutes + "minutes";
            cbShortBreak.SelectedItem = Timer.shortBreakTimeMinutes + "minutes";
            cbLongBreak.SelectedItem = Timer.longBreakTimeMinutes + "minutes";
            cbLongInterval.SelectedItem = Timer.longBreakInterval + "Pomodoros";
        }

        private void updateSetting()
        {
            worktime = Timer.workTimeMinutes;
            shortbreak = Timer.shortBreakTimeMinutes;
            longbreak = Timer.longBreakTimeMinutes;
            stopWatchTime = Timer.stopWatchTimer;
            updateTimeLabel(0);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!start)
            {
                start = true;

                if (isBreaktime)
                {
                    if (pomodorocunter == Timer.longBreakInterval)
                    {
                        startTimer(2);
                        pomodorocunter = 0;
                    }
                    else
                        startTimer(1);
                }
                else
                    startTimer(0);
            }
            else if (start)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to stop?", "Pomodoro", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    start = false;
                    timer.Stop();
                    btnStartS.Enabled = true;
                    Timer.workTimePlayer.Stop();
                    updateSetting();
                    updateTimeLabel(worktime);
                    btnStart.Text = "Start";
                    btnStart.BackColor = Color.LightGreen;
                    btnStart.FlatAppearance.BorderColor = Color.Green;
                }

            }
        }

        private void startTimer(int timeType)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler((sender, e) => timer1_Tick(sender, e, timeType));
            timer.Interval = 1000; // 1 second
            timer.Start();
            btnStartS.Enabled = false;
            Timer.workTimePlayer.PlayLooping();
            btnStart.Text = "Stop";
            btnStart.BackColor = Color.LightCoral;
            btnStart.FlatAppearance.BorderColor = Color.Red;
        }

        private void timer1_Tick(object sender, EventArgs e, int timeType)
        {
            updateTimeLabel(timeType);

            if (timeType == 0)
            {
                worktime--;
                checkForStop(worktime,timeType);
            }
            else if (timeType == 1)
            {
                shortbreak--;
                checkForStop(shortbreak, timeType);
            }
            else if (timeType == 2)
            {
                longbreak--;
                checkForStop(longbreak, timeType);
            }

        }

        private void checkForStop(int time, int timeType)
        {
            if (time == 0)
            {
                timer.Stop();
                btnStartS.Enabled = true;
                start = false;
                Timer.workTimePlayer.Stop();

                if (isBreaktime)
                {
                    addToTotalTime(timeType);
                    isBreaktime = false;
                    Timer.breakTimePlayer.Play();
                    Timer.breakTimePlayer.Stop();
                    updateSetting();
                    lblPomodoroCount.Text = "Today | Pomodoros: " + currentTask.pomodoros;
                    btnStart.Text = "Start";
                    lblPomodoroStatus.Text = "Time until break";
                    btnStart.BackColor = Color.LightGreen;
                    btnStart.FlatAppearance.BorderColor = Color.Green;

                }
                else if (!isBreaktime)
                {
                    addToTotalTime(timeType);
                    pomodorocunter++;
                    currentTask.pomodoros += pomodorocunter;
                    lblPomodoroCount.Text = "Today | Pomodoros: " + currentTask.pomodoros;
                    isBreaktime = true;
                    Timer.breakTimePlayer.PlaySync();
                    Timer.breakTimePlayer.Stop();
                    btnStart.Text = "Start";
                    btnStart.BackColor = Color.LightGreen;
                    btnStart.FlatAppearance.BorderColor = Color.Green;

                    lblPomodoroStatus.Text = "Take break";

                    if (pomodorocunter == Timer.longBreakInterval)
                    {
                        updateTimeLabel(2);
                    }
                    else
                    {
                        updateTimeLabel(1);
                    }

                }

            }
        }

        private void addToTotalTime(int type)
        {
            switch (type)
            {
                case 0:
                    currentTask.totalTaskTime = currentTask.totalTaskTime.Add(new TimeSpan(0,Timer.workTimeMinutes,0));
                    break;
                case 1:
                    currentTask.totalTaskTime = currentTask.totalTaskTime.Add(new TimeSpan(0,Timer.shortBreakTimeMinutes, 0));
                    break;
                case 2:
                    currentTask.totalTaskTime = currentTask.totalTaskTime.Add(new TimeSpan(0,Timer.longBreakTimeMinutes, 0));
                    break;
                case 3:
                    break;
            }
            updateSettingToDB(4);
            updateSettingToDB(5);
            lblTotalTime.Text = "Total task time: " + currentTask.totalTaskTime;
            lblTotalTimeS.Text = "Total task time: " + currentTask.totalTaskTime;
            lblTotalTaskTimeAddTime.Text = "Total task time: " + currentTask.totalTaskTime;

        }

        private void updateTimeLabel(int timeType)
        {
            if (timeType == 0)
            {
                lblCountDown.Text = worktime / 60 + ":" + ((worktime % 60) >= 10 ? (worktime % 60).ToString() : "0" + worktime % 60);
            }
            else if (timeType == 1)
            {
                lblCountDown.Text = shortbreak / 60 + ":" + ((shortbreak % 60) >= 10 ? (shortbreak % 60).ToString() : "0" + shortbreak % 60);
            }
            else if (timeType == 2)
            {
                lblCountDown.Text = longbreak / 60 + ":" + ((longbreak % 60) >= 10 ? (longbreak % 60).ToString() : "0" + longbreak % 60);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            readSetting();
            updateSettingToDB();
            updateSetting();
            MessageBox.Show(this, "Settings updated!!", "Pomodoro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void updateSettingToDB(int type)
        {
            switch (type)
            {
                case 0:
                    DBUtility.cmd = new SqlCommand("UPDATE [Pomodoro].[dbo].[PomodoroSettings] SET [Value] = " + Timer.workTimeMinutes / 60 + " WHERE [Field] = 'workTimeMinutes'", DBUtility.con);
                    DBUtility.cmd.ExecuteNonQuery();

                    break;
                case 1:
                    DBUtility.cmd = new SqlCommand("UPDATE [Pomodoro].[dbo].[PomodoroSettings] SET [Value] = " + Timer.shortBreakTimeMinutes / 60 + " WHERE [Field] = 'shortBreakTimeMinutes'", DBUtility.con);
                    DBUtility.cmd.ExecuteNonQuery();

                    break;
                case 2:
                    DBUtility.cmd = new SqlCommand("UPDATE [Pomodoro].[dbo].[PomodoroSettings] SET [Value] = " + Timer.longBreakTimeMinutes / 60 + " WHERE [Field] = 'longBreakTimeMinutes'", DBUtility.con);
                    DBUtility.cmd.ExecuteNonQuery();

                    break;
                case 3:
                    DBUtility.cmd = new SqlCommand("UPDATE [Pomodoro].[dbo].[PomodoroSettings] SET [Value] = " + Timer.longBreakInterval + " WHERE [Field] = 'longBreakInterval'", DBUtility.con);
                    DBUtility.cmd.ExecuteNonQuery();

                    break;
                case 4:
                    DBUtility.cmd = new SqlCommand("UPDATE [Pomodoro].[dbo].[Tasks] SET [TOTAL_TASKTIME] = " + "'" + currentTask.totalTaskTime + "'" + " WHERE [ID] = " + currentTask.id, DBUtility.con);
                    DBUtility.cmd.ExecuteNonQuery();

                    break;
                case 5:
                    DBUtility.cmd = new SqlCommand("UPDATE [Pomodoro].[dbo].[Tasks] SET [POMODOROS] = " + "'" + currentTask.pomodoros + "'" + " WHERE [ID] = "+ currentTask.id, DBUtility.con);
                    DBUtility.cmd.ExecuteNonQuery();
                    break;
            }
        }

        private void updateSettingToDB()
        {
            DBUtility.cmd = new SqlCommand("UPDATE [Pomodoro].[dbo].[PomodoroSettings] SET [Value] = " + Timer.workTimeMinutes / 60 + " WHERE [Field] = 'workTimeMinutes'", DBUtility.con);
            DBUtility.cmd.ExecuteNonQuery();

            DBUtility.cmd = new SqlCommand("UPDATE [Pomodoro].[dbo].[PomodoroSettings] SET [Value] = " + Timer.shortBreakTimeMinutes / 60 + " WHERE [Field] = 'shortBreakTimeMinutes'", DBUtility.con);
            DBUtility.cmd.ExecuteNonQuery();

            DBUtility.cmd = new SqlCommand("UPDATE [Pomodoro].[dbo].[PomodoroSettings] SET [Value] = " + Timer.longBreakTimeMinutes / 60 + " WHERE [Field] = 'longBreakTimeMinutes'", DBUtility.con);
            DBUtility.cmd.ExecuteNonQuery();

            DBUtility.cmd = new SqlCommand("UPDATE [Pomodoro].[dbo].[PomodoroSettings] SET [Value] = " + Timer.longBreakInterval + " WHERE [Field] = 'longBreakInterval'", DBUtility.con);
            DBUtility.cmd.ExecuteNonQuery();


        }

        private void readSetting()
        {
            int worktimeIndex = cbWorktime.SelectedIndex;
            switch (worktimeIndex)
            {
                case 0:
                    Timer.workTimeMinutes = 60 * 15;
                    break;
                case 1:
                    Timer.workTimeMinutes = 60 * 25;
                    break;
                case 2:
                    Timer.workTimeMinutes = 60 * 35;
                    break;
                case 3:
                    Timer.workTimeMinutes = 60 * 45;
                    break;
            }

            int shortBreaktimeIndex = cbShortBreak.SelectedIndex;
            switch (shortBreaktimeIndex)
            {
                case 0:
                    Timer.shortBreakTimeMinutes = 60 * 2;
                    break;
                case 1:
                    Timer.shortBreakTimeMinutes = 60 * 5;
                    break;
                case 2:
                    Timer.shortBreakTimeMinutes = 60 * 10;
                    break;
                case 3:
                    Timer.shortBreakTimeMinutes = 60 * 15;
                    break;
            }

            int longBreaktimeIndex = cbLongBreak.SelectedIndex;
            switch (longBreaktimeIndex)
            {
                case 0:
                    Timer.longBreakTimeMinutes = 60 * 15;
                    break;
                case 1:
                    Timer.longBreakTimeMinutes = 60 * 20;
                    break;
                case 2:
                    Timer.longBreakTimeMinutes = 60 * 25;
                    break;
                case 3:
                    Timer.longBreakTimeMinutes = 60 * 30;
                    break;
            }

            int longBreakIntervalIndex = cbLongInterval.SelectedIndex;
            switch (longBreakIntervalIndex)
            {
                case 0:
                    Timer.longBreakInterval = 2;
                    break;
                case 1:
                    Timer.longBreakInterval = 4;
                    break;
                case 2:
                    Timer.longBreakInterval = 6;
                    break;
                case 3:
                    Timer.longBreakInterval = 8;
                    break;
            }
        }

        private void btnStartS_Click(object sender, EventArgs e)
        {
            if (!startStopWatch)
            {
                startStopWatch = true;
                stopWatchtimer = new System.Windows.Forms.Timer();
                stopWatchtimer.Tick += new EventHandler((sender1, e1) => timer1_UpTick(sender1, e1));
                stopWatchtimer.Interval = 1000; // 1 second
                stopWatchtimer.Start();
                btnStart.Enabled = false;
                Timer.workTimePlayer.PlayLooping();
                btnStartS.Text = "Stop";
                btnStartS.BackColor = Color.LightCoral;
                btnStartS.FlatAppearance.BorderColor = Color.Red;
            }
            else if (startStopWatch)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to stop?", "Stopwatch", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    currentTask.totalTaskTime = currentTask.totalTaskTime.Add(new TimeSpan(0, 0,(stopWatchTime)));

                    lblTotalTime.Text = "Total task time: " + currentTask.totalTaskTime;
                    lblTotalTimeS.Text = "Total task time: " + currentTask.totalTaskTime;
                    lblTotalTaskTimeAddTime.Text = "Total task time: " + currentTask.totalTaskTime;

                    updateSettingToDB(4);

                    startStopWatch = false;
                    stopWatchtimer.Stop();
                    updateSetting();
                    updateSWLabel();
                    btnStart.Enabled = true;
                    sessionsSW++;
                    lblSessions.Text = "Today | Sessions: " + sessionsSW;

                    Timer.workTimePlayer.Stop();

                    btnStartS.Text = "Start";
                    btnStartS.BackColor = Color.LightGreen;
                    btnStartS.FlatAppearance.BorderColor = Color.Green;
                }

            }
        }
        private void timer1_UpTick(object sender, EventArgs e)
        {
            stopWatchTime++;
            updateSWLabel();
        }

        private void updateSWLabel()
        {
            lblStopWatch.Text = stopWatchTime / 60 + ":" + ((stopWatchTime % 60) >= 10 ? (stopWatchTime % 60).ToString() : "0" + stopWatchTime % 60);
        }

        private void btnUpdateTime_Click(object sender, EventArgs e)
        {
            int addWorktimeIndex = cbAddWorkTime.SelectedIndex;
            switch (addWorktimeIndex)
            {
                case 0:
                    currentTask.totalTaskTime = currentTask.totalTaskTime.Add(new TimeSpan(0, 15, 0));
                    break;
                case 1:
                    currentTask.totalTaskTime = currentTask.totalTaskTime.Add(new TimeSpan(0, 30, 0));
                    break;
                case 2:
                    currentTask.totalTaskTime = currentTask.totalTaskTime.Add(new TimeSpan(0, 45, 0));
                    break;
                case 3:
                    currentTask.totalTaskTime = currentTask.totalTaskTime.Add(new TimeSpan(1, 0, 0));
                    break;
                case 4:
                    currentTask.totalTaskTime = currentTask.totalTaskTime.Add(new TimeSpan(2, 0, 0));
                    break;
                case 5:
                    currentTask.totalTaskTime = currentTask.totalTaskTime.Add(new TimeSpan(3, 0, 0));
                    break;
                case 6:
                    currentTask.totalTaskTime = currentTask.totalTaskTime.Add(new TimeSpan(4, 0, 0));
                    break;
            }
            updateSettingToDB(4);
            MessageBox.Show(this, "Time added!!", "Pomodoro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblTotalTime.Text = "Total task time: " + currentTask.totalTaskTime;
            lblTotalTimeS.Text = "Total task time: " + currentTask.totalTaskTime;
            lblTotalTaskTimeAddTime.Text = "Total task time: " + currentTask.totalTaskTime;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cbAddWorkTime.SelectedIndex = 0;
        }
    }
}
