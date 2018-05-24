namespace WorkList
{
    partial class Pomodoro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pomodoro));
            this.appTabs = new System.Windows.Forms.TabControl();
            this.tabPomodoro = new System.Windows.Forms.TabPage();
            this.lblPomodoroStatus = new System.Windows.Forms.Label();
            this.lblPomodoroCount = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tabStopWatch = new System.Windows.Forms.TabPage();
            this.lblTaskS = new System.Windows.Forms.Label();
            this.lblSessions = new System.Windows.Forms.Label();
            this.lblTotalTimeS = new System.Windows.Forms.Label();
            this.lblStopWatch = new System.Windows.Forms.Label();
            this.btnStartS = new System.Windows.Forms.Button();
            this.tabAddTime = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdateTime = new System.Windows.Forms.Button();
            this.lblTaskAddtime = new System.Windows.Forms.Label();
            this.lblTotalTaskTimeAddTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAddWorkTime = new System.Windows.Forms.ComboBox();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbLongInterval = new System.Windows.Forms.ComboBox();
            this.cbLongBreak = new System.Windows.Forms.ComboBox();
            this.cbShortBreak = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbWorktime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.appTabs.SuspendLayout();
            this.tabPomodoro.SuspendLayout();
            this.tabStopWatch.SuspendLayout();
            this.tabAddTime.SuspendLayout();
            this.tabSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // appTabs
            // 
            this.appTabs.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.appTabs.Controls.Add(this.tabPomodoro);
            this.appTabs.Controls.Add(this.tabStopWatch);
            this.appTabs.Controls.Add(this.tabAddTime);
            this.appTabs.Controls.Add(this.tabLog);
            this.appTabs.Controls.Add(this.tabSetting);
            this.appTabs.ImageList = this.IconList;
            this.appTabs.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.appTabs.ItemSize = new System.Drawing.Size(78, 60);
            this.appTabs.Location = new System.Drawing.Point(0, 0);
            this.appTabs.Margin = new System.Windows.Forms.Padding(0);
            this.appTabs.Name = "appTabs";
            this.appTabs.SelectedIndex = 0;
            this.appTabs.Size = new System.Drawing.Size(400, 458);
            this.appTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.appTabs.TabIndex = 0;
            // 
            // tabPomodoro
            // 
            this.tabPomodoro.Controls.Add(this.lblPomodoroStatus);
            this.tabPomodoro.Controls.Add(this.lblPomodoroCount);
            this.tabPomodoro.Controls.Add(this.lblTotalTime);
            this.tabPomodoro.Controls.Add(this.lblTask);
            this.tabPomodoro.Controls.Add(this.lblCountDown);
            this.tabPomodoro.Controls.Add(this.btnStart);
            this.tabPomodoro.ImageIndex = 4;
            this.tabPomodoro.Location = new System.Drawing.Point(4, 4);
            this.tabPomodoro.Margin = new System.Windows.Forms.Padding(0);
            this.tabPomodoro.Name = "tabPomodoro";
            this.tabPomodoro.Size = new System.Drawing.Size(392, 390);
            this.tabPomodoro.TabIndex = 0;
            this.tabPomodoro.UseVisualStyleBackColor = true;
            // 
            // lblPomodoroStatus
            // 
            this.lblPomodoroStatus.BackColor = System.Drawing.Color.White;
            this.lblPomodoroStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPomodoroStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPomodoroStatus.Location = new System.Drawing.Point(37, 154);
            this.lblPomodoroStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lblPomodoroStatus.Name = "lblPomodoroStatus";
            this.lblPomodoroStatus.Size = new System.Drawing.Size(313, 29);
            this.lblPomodoroStatus.TabIndex = 13;
            this.lblPomodoroStatus.Text = "Time until break";
            this.lblPomodoroStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPomodoroCount
            // 
            this.lblPomodoroCount.BackColor = System.Drawing.Color.White;
            this.lblPomodoroCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPomodoroCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPomodoroCount.Location = new System.Drawing.Point(34, 343);
            this.lblPomodoroCount.Margin = new System.Windows.Forms.Padding(0);
            this.lblPomodoroCount.Name = "lblPomodoroCount";
            this.lblPomodoroCount.Size = new System.Drawing.Size(316, 29);
            this.lblPomodoroCount.TabIndex = 12;
            this.lblPomodoroCount.Text = "Today | Pomodoros: 0";
            this.lblPomodoroCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTotalTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTime.Location = new System.Drawing.Point(-3, 40);
            this.lblTotalTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(390, 40);
            this.lblTotalTime.TabIndex = 11;
            this.lblTotalTime.Text = "Total task time: 00:00";
            this.lblTotalTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTask
            // 
            this.lblTask.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask.Location = new System.Drawing.Point(-3, 0);
            this.lblTask.Margin = new System.Windows.Forms.Padding(0);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(390, 40);
            this.lblTask.TabIndex = 10;
            this.lblTask.Text = "No task selected";
            this.lblTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCountDown
            // 
            this.lblCountDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.Location = new System.Drawing.Point(37, 183);
            this.lblCountDown.Margin = new System.Windows.Forms.Padding(0);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(313, 160);
            this.lblCountDown.TabIndex = 9;
            this.lblCountDown.Text = "00:00";
            this.lblCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightGreen;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(136, 103);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(117, 48);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tabStopWatch
            // 
            this.tabStopWatch.Controls.Add(this.lblTaskS);
            this.tabStopWatch.Controls.Add(this.lblSessions);
            this.tabStopWatch.Controls.Add(this.lblTotalTimeS);
            this.tabStopWatch.Controls.Add(this.lblStopWatch);
            this.tabStopWatch.Controls.Add(this.btnStartS);
            this.tabStopWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStopWatch.ImageIndex = 3;
            this.tabStopWatch.Location = new System.Drawing.Point(4, 4);
            this.tabStopWatch.Margin = new System.Windows.Forms.Padding(0);
            this.tabStopWatch.Name = "tabStopWatch";
            this.tabStopWatch.Size = new System.Drawing.Size(392, 390);
            this.tabStopWatch.TabIndex = 4;
            this.tabStopWatch.UseVisualStyleBackColor = true;
            // 
            // lblTaskS
            // 
            this.lblTaskS.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTaskS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTaskS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskS.Location = new System.Drawing.Point(-3, 0);
            this.lblTaskS.Margin = new System.Windows.Forms.Padding(0);
            this.lblTaskS.Name = "lblTaskS";
            this.lblTaskS.Size = new System.Drawing.Size(390, 40);
            this.lblTaskS.TabIndex = 19;
            this.lblTaskS.Text = "No task selected";
            this.lblTaskS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSessions
            // 
            this.lblSessions.BackColor = System.Drawing.Color.White;
            this.lblSessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessions.Location = new System.Drawing.Point(34, 345);
            this.lblSessions.Margin = new System.Windows.Forms.Padding(0);
            this.lblSessions.Name = "lblSessions";
            this.lblSessions.Size = new System.Drawing.Size(316, 29);
            this.lblSessions.TabIndex = 17;
            this.lblSessions.Text = "Today | Sessions: 0";
            this.lblSessions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalTimeS
            // 
            this.lblTotalTimeS.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTotalTimeS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalTimeS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTimeS.Location = new System.Drawing.Point(0, 40);
            this.lblTotalTimeS.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalTimeS.Name = "lblTotalTimeS";
            this.lblTotalTimeS.Size = new System.Drawing.Size(387, 40);
            this.lblTotalTimeS.TabIndex = 16;
            this.lblTotalTimeS.Text = "Total task time: 00:00";
            this.lblTotalTimeS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStopWatch
            // 
            this.lblStopWatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStopWatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStopWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopWatch.Location = new System.Drawing.Point(37, 172);
            this.lblStopWatch.Margin = new System.Windows.Forms.Padding(0);
            this.lblStopWatch.Name = "lblStopWatch";
            this.lblStopWatch.Size = new System.Drawing.Size(313, 160);
            this.lblStopWatch.TabIndex = 15;
            this.lblStopWatch.Text = "00:00";
            this.lblStopWatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartS
            // 
            this.btnStartS.BackColor = System.Drawing.Color.LightGreen;
            this.btnStartS.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnStartS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartS.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStartS.Location = new System.Drawing.Point(136, 105);
            this.btnStartS.Name = "btnStartS";
            this.btnStartS.Size = new System.Drawing.Size(117, 48);
            this.btnStartS.TabIndex = 14;
            this.btnStartS.Text = "Start";
            this.btnStartS.UseVisualStyleBackColor = false;
            this.btnStartS.Click += new System.EventHandler(this.btnStartS_Click);
            // 
            // tabAddTime
            // 
            this.tabAddTime.Controls.Add(this.btnCancel);
            this.tabAddTime.Controls.Add(this.btnUpdateTime);
            this.tabAddTime.Controls.Add(this.lblTaskAddtime);
            this.tabAddTime.Controls.Add(this.lblTotalTaskTimeAddTime);
            this.tabAddTime.Controls.Add(this.label2);
            this.tabAddTime.Controls.Add(this.cbAddWorkTime);
            this.tabAddTime.ImageIndex = 0;
            this.tabAddTime.Location = new System.Drawing.Point(4, 4);
            this.tabAddTime.Margin = new System.Windows.Forms.Padding(0);
            this.tabAddTime.Name = "tabAddTime";
            this.tabAddTime.Size = new System.Drawing.Size(392, 390);
            this.tabAddTime.TabIndex = 1;
            this.tabAddTime.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(58, 269);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 38);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdateTime
            // 
            this.btnUpdateTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTime.Location = new System.Drawing.Point(192, 269);
            this.btnUpdateTime.Name = "btnUpdateTime";
            this.btnUpdateTime.Size = new System.Drawing.Size(142, 38);
            this.btnUpdateTime.TabIndex = 22;
            this.btnUpdateTime.Text = "Update";
            this.btnUpdateTime.UseVisualStyleBackColor = true;
            this.btnUpdateTime.Click += new System.EventHandler(this.btnUpdateTime_Click);
            // 
            // lblTaskAddtime
            // 
            this.lblTaskAddtime.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTaskAddtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTaskAddtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskAddtime.Location = new System.Drawing.Point(-5, 0);
            this.lblTaskAddtime.Margin = new System.Windows.Forms.Padding(0);
            this.lblTaskAddtime.Name = "lblTaskAddtime";
            this.lblTaskAddtime.Size = new System.Drawing.Size(390, 40);
            this.lblTaskAddtime.TabIndex = 21;
            this.lblTaskAddtime.Text = "No task selected";
            this.lblTaskAddtime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalTaskTimeAddTime
            // 
            this.lblTotalTaskTimeAddTime.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTotalTaskTimeAddTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalTaskTimeAddTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTaskTimeAddTime.Location = new System.Drawing.Point(-2, 40);
            this.lblTotalTaskTimeAddTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalTaskTimeAddTime.Name = "lblTotalTaskTimeAddTime";
            this.lblTotalTaskTimeAddTime.Size = new System.Drawing.Size(387, 40);
            this.lblTotalTaskTimeAddTime.TabIndex = 20;
            this.lblTotalTaskTimeAddTime.Text = "Total task time: 00:00";
            this.lblTotalTaskTimeAddTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add Worktime: ";
            // 
            // cbAddWorkTime
            // 
            this.cbAddWorkTime.FormattingEnabled = true;
            this.cbAddWorkTime.Items.AddRange(new object[] {
            "15 minutes",
            "30 minutes",
            "45 minutes",
            "1 hour",
            "2 hours",
            "3 hours",
            "4 hours"});
            this.cbAddWorkTime.Location = new System.Drawing.Point(192, 168);
            this.cbAddWorkTime.Name = "cbAddWorkTime";
            this.cbAddWorkTime.Size = new System.Drawing.Size(142, 21);
            this.cbAddWorkTime.TabIndex = 2;
            this.cbAddWorkTime.Text = "25 minutes";
            // 
            // tabLog
            // 
            this.tabLog.ImageIndex = 1;
            this.tabLog.Location = new System.Drawing.Point(4, 4);
            this.tabLog.Margin = new System.Windows.Forms.Padding(0);
            this.tabLog.Name = "tabLog";
            this.tabLog.Size = new System.Drawing.Size(392, 390);
            this.tabLog.TabIndex = 2;
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // tabSetting
            // 
            this.tabSetting.Controls.Add(this.btnUpdate);
            this.tabSetting.Controls.Add(this.cbLongInterval);
            this.tabSetting.Controls.Add(this.cbLongBreak);
            this.tabSetting.Controls.Add(this.cbShortBreak);
            this.tabSetting.Controls.Add(this.label6);
            this.tabSetting.Controls.Add(this.label5);
            this.tabSetting.Controls.Add(this.label4);
            this.tabSetting.Controls.Add(this.cbWorktime);
            this.tabSetting.Controls.Add(this.label1);
            this.tabSetting.ImageIndex = 2;
            this.tabSetting.Location = new System.Drawing.Point(4, 4);
            this.tabSetting.Margin = new System.Windows.Forms.Padding(0);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Size = new System.Drawing.Size(392, 390);
            this.tabSetting.TabIndex = 3;
            this.tabSetting.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(174, 287);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(142, 38);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbLongInterval
            // 
            this.cbLongInterval.FormattingEnabled = true;
            this.cbLongInterval.Items.AddRange(new object[] {
            "2 Pomodoros",
            "4 Pomodoros",
            "6 Pomodoros",
            "8 Pomodoros"});
            this.cbLongInterval.Location = new System.Drawing.Point(174, 233);
            this.cbLongInterval.Name = "cbLongInterval";
            this.cbLongInterval.Size = new System.Drawing.Size(142, 21);
            this.cbLongInterval.TabIndex = 7;
            this.cbLongInterval.Text = "4 Pomodoros";
            // 
            // cbLongBreak
            // 
            this.cbLongBreak.FormattingEnabled = true;
            this.cbLongBreak.Items.AddRange(new object[] {
            "15 minutes",
            "20 minutes",
            "25 minutes",
            "30 minutes"});
            this.cbLongBreak.Location = new System.Drawing.Point(174, 167);
            this.cbLongBreak.Name = "cbLongBreak";
            this.cbLongBreak.Size = new System.Drawing.Size(142, 21);
            this.cbLongBreak.TabIndex = 6;
            this.cbLongBreak.Text = "15 minutes";
            // 
            // cbShortBreak
            // 
            this.cbShortBreak.FormattingEnabled = true;
            this.cbShortBreak.Items.AddRange(new object[] {
            "2 minutes",
            "5 minutes",
            "10 minutes",
            "15 minutes"});
            this.cbShortBreak.Location = new System.Drawing.Point(174, 95);
            this.cbShortBreak.Name = "cbShortBreak";
            this.cbShortBreak.Size = new System.Drawing.Size(142, 21);
            this.cbShortBreak.TabIndex = 5;
            this.cbShortBreak.Text = "5 minutes";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Long break interval";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Long break time";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Short break time";
            // 
            // cbWorktime
            // 
            this.cbWorktime.FormattingEnabled = true;
            this.cbWorktime.Items.AddRange(new object[] {
            "15 minutes",
            "25 minutes",
            "35 minutes",
            "45 minutes"});
            this.cbWorktime.Location = new System.Drawing.Point(174, 30);
            this.cbWorktime.Name = "cbWorktime";
            this.cbWorktime.Size = new System.Drawing.Size(142, 21);
            this.cbWorktime.TabIndex = 1;
            this.cbWorktime.Text = "25 minutes";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Work time";
            // 
            // IconList
            // 
            this.IconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconList.ImageStream")));
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconList.Images.SetKeyName(0, "addTime.png");
            this.IconList.Images.SetKeyName(1, "database.png");
            this.IconList.Images.SetKeyName(2, "setting.png");
            this.IconList.Images.SetKeyName(3, "stopwatch.png");
            this.IconList.Images.SetKeyName(4, "tomato.png");
            // 
            // Pomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(393, 458);
            this.Controls.Add(this.appTabs);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(409, 497);
            this.MinimumSize = new System.Drawing.Size(409, 497);
            this.Name = "Pomodoro";
            this.Text = "Pomodoro";
            this.appTabs.ResumeLayout(false);
            this.tabPomodoro.ResumeLayout(false);
            this.tabStopWatch.ResumeLayout(false);
            this.tabAddTime.ResumeLayout(false);
            this.tabSetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl appTabs;
        private System.Windows.Forms.TabPage tabAddTime;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.TabPage tabSetting;
        private System.Windows.Forms.TabPage tabPomodoro;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TabPage tabStopWatch;
        private System.Windows.Forms.Label lblPomodoroStatus;
        private System.Windows.Forms.Label lblPomodoroCount;
        private System.Windows.Forms.ComboBox cbWorktime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLongInterval;
        private System.Windows.Forms.ComboBox cbLongBreak;
        private System.Windows.Forms.ComboBox cbShortBreak;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.ImageList IconList;
        private System.Windows.Forms.Label lblTaskS;
        private System.Windows.Forms.Label lblSessions;
        private System.Windows.Forms.Label lblTotalTimeS;
        private System.Windows.Forms.Label lblStopWatch;
        private System.Windows.Forms.Button btnStartS;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Label lblTaskAddtime;
        private System.Windows.Forms.Label lblTotalTaskTimeAddTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAddWorkTime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdateTime;
    }
}

