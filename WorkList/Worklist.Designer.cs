namespace WorkList
{
    partial class Worklist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Worklist));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelToday = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelToDoList = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTask = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonToDoList = new System.Windows.Forms.Button();
            this.panelHistory = new System.Windows.Forms.Panel();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskDeadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelayReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_TASKTIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POMODOROS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonShow = new System.Windows.Forms.Button();
            this.dateTimePickerHistory = new System.Windows.Forms.DateTimePicker();
            this.labelEnterDate = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelToDoList.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelTop.Controls.Add(this.labelToday);
            this.panelTop.Controls.Add(this.labelHeader);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(716, 74);
            this.panelTop.TabIndex = 0;
            // 
            // labelToday
            // 
            this.labelToday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToday.ForeColor = System.Drawing.Color.White;
            this.labelToday.Location = new System.Drawing.Point(444, 19);
            this.labelToday.Name = "labelToday";
            this.labelToday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelToday.Size = new System.Drawing.Size(267, 39);
            this.labelToday.TabIndex = 1;
            this.labelToday.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.labelHeader.Location = new System.Drawing.Point(12, 19);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(112, 41);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "To Do";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "tick.png");
            this.imageList1.Images.SetKeyName(1, "trash.png");
            this.imageList1.Images.SetKeyName(2, "tomato.ico");
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.ColumnCount = 6;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.51632F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.48368F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Location = new System.Drawing.Point(22, 63);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(578, 33);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // panelToDoList
            // 
            this.panelToDoList.AutoScroll = true;
            this.panelToDoList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelToDoList.Controls.Add(this.buttonRefresh);
            this.panelToDoList.Controls.Add(this.buttonSave);
            this.panelToDoList.Controls.Add(this.labelTime);
            this.panelToDoList.Controls.Add(this.labelDate);
            this.panelToDoList.Controls.Add(this.labelTask);
            this.panelToDoList.Controls.Add(this.tableLayoutPanel);
            this.panelToDoList.Location = new System.Drawing.Point(92, 74);
            this.panelToDoList.Name = "panelToDoList";
            this.panelToDoList.Size = new System.Drawing.Size(612, 293);
            this.panelToDoList.TabIndex = 3;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRefresh.Location = new System.Drawing.Point(349, 6);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(111, 32);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSave.Location = new System.Drawing.Point(489, 6);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(111, 32);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save Changes";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(518, 44);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(38, 16);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "Time";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(422, 44);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(38, 16);
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "Date";
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTask.Location = new System.Drawing.Point(175, 44);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(37, 16);
            this.labelTask.TabIndex = 6;
            this.labelTask.Text = "Task";
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelButtons.Controls.Add(this.buttonHistory);
            this.panelButtons.Controls.Add(this.buttonToDoList);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 74);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(93, 327);
            this.panelButtons.TabIndex = 4;
            // 
            // buttonHistory
            // 
            this.buttonHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistory.ForeColor = System.Drawing.Color.White;
            this.buttonHistory.Location = new System.Drawing.Point(0, 41);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(92, 44);
            this.buttonHistory.TabIndex = 1;
            this.buttonHistory.Text = "History";
            this.buttonHistory.UseVisualStyleBackColor = false;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // buttonToDoList
            // 
            this.buttonToDoList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonToDoList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToDoList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToDoList.ForeColor = System.Drawing.Color.White;
            this.buttonToDoList.Location = new System.Drawing.Point(1, 0);
            this.buttonToDoList.Name = "buttonToDoList";
            this.buttonToDoList.Size = new System.Drawing.Size(92, 44);
            this.buttonToDoList.TabIndex = 0;
            this.buttonToDoList.Text = "To Do List";
            this.buttonToDoList.UseVisualStyleBackColor = false;
            this.buttonToDoList.Click += new System.EventHandler(this.buttonToDoList_Click);
            // 
            // panelHistory
            // 
            this.panelHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelHistory.Controls.Add(this.btnShowAll);
            this.panelHistory.Controls.Add(this.dataGridViewHistory);
            this.panelHistory.Controls.Add(this.buttonShow);
            this.panelHistory.Controls.Add(this.dateTimePickerHistory);
            this.panelHistory.Controls.Add(this.labelEnterDate);
            this.panelHistory.Location = new System.Drawing.Point(99, 80);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Size = new System.Drawing.Size(613, 323);
            this.panelHistory.TabIndex = 5;
            this.panelHistory.Visible = false;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowAll.Location = new System.Drawing.Point(499, 27);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(79, 23);
            this.btnShowAll.TabIndex = 4;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task,
            this.TaskDeadline,
            this.TaskStatus,
            this.DelayReason,
            this.TOTAL_TASKTIME,
            this.POMODOROS});
            this.dataGridViewHistory.Location = new System.Drawing.Point(29, 76);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.Size = new System.Drawing.Size(549, 181);
            this.dataGridViewHistory.TabIndex = 3;
            // 
            // Task
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Task.DefaultCellStyle = dataGridViewCellStyle1;
            this.Task.HeaderText = "Task";
            this.Task.Name = "Task";
            this.Task.Width = 56;
            // 
            // TaskDeadline
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TaskDeadline.DefaultCellStyle = dataGridViewCellStyle2;
            this.TaskDeadline.HeaderText = "Task Deadline";
            this.TaskDeadline.Name = "TaskDeadline";
            this.TaskDeadline.Width = 101;
            // 
            // TaskStatus
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TaskStatus.DefaultCellStyle = dataGridViewCellStyle3;
            this.TaskStatus.HeaderText = "Task Status";
            this.TaskStatus.Name = "TaskStatus";
            this.TaskStatus.Width = 89;
            // 
            // DelayReason
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DelayReason.DefaultCellStyle = dataGridViewCellStyle4;
            this.DelayReason.HeaderText = "Delay Reason";
            this.DelayReason.Name = "DelayReason";
            this.DelayReason.Width = 99;
            // 
            // TOTAL_TASKTIME
            // 
            this.TOTAL_TASKTIME.HeaderText = "TOTAL_TASKTIME";
            this.TOTAL_TASKTIME.Name = "TOTAL_TASKTIME";
            this.TOTAL_TASKTIME.Width = 127;
            // 
            // POMODOROS
            // 
            this.POMODOROS.HeaderText = "POMODOROS";
            this.POMODOROS.Name = "POMODOROS";
            this.POMODOROS.Width = 103;
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShow.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonShow.Location = new System.Drawing.Point(400, 28);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(79, 23);
            this.buttonShow.TabIndex = 2;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // dateTimePickerHistory
            // 
            this.dateTimePickerHistory.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dateTimePickerHistory.Location = new System.Drawing.Point(145, 28);
            this.dateTimePickerHistory.Name = "dateTimePickerHistory";
            this.dateTimePickerHistory.Size = new System.Drawing.Size(216, 23);
            this.dateTimePickerHistory.TabIndex = 1;
            // 
            // labelEnterDate
            // 
            this.labelEnterDate.AutoSize = true;
            this.labelEnterDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterDate.Location = new System.Drawing.Point(26, 34);
            this.labelEnterDate.Name = "labelEnterDate";
            this.labelEnterDate.Size = new System.Drawing.Size(80, 17);
            this.labelEnterDate.TabIndex = 0;
            this.labelEnterDate.Text = "Enter Date:";
            // 
            // Worklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(716, 401);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelToDoList);
            this.Controls.Add(this.panelHistory);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Worklist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To Do";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelToDoList.ResumeLayout(false);
            this.panelToDoList.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelHistory.ResumeLayout(false);
            this.panelHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelToday;
        private System.Windows.Forms.Panel panelToDoList;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonToDoList;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Panel panelHistory;
        private System.Windows.Forms.DateTimePicker dateTimePickerHistory;
        private System.Windows.Forms.Label labelEnterDate;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskDeadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn DelayReason;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_TASKTIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn POMODOROS;
    }
}

