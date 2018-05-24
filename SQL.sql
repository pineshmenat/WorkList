USE [master]
GO
CREATE DATABASE [Pomodoro]
GO
USE [Pomodoro]
GO

/****** Object:  Table [dbo].[PomodoroSettings]    Script Date: 2017-07-24 4:49:29 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PomodoroSettings](
	[Field] [nvarchar](250) NULL,
	[Value] [int] NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Tasks]    Script Date: 2017-07-24 4:49:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tasks](
	[ID] [int] NOT NULL,
	[TASK] [nvarchar](150) NULL,
	[IS_TASK_DONE] [char](1) NULL,
	[DELAY_REASON] [nvarchar](150) NULL,
	[TASK_COMPLETION_DATETIME] [datetime] NULL,
	[TOTAL_TASKTIME] [time](7) NULL,
	[POMODOROS] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [dbo].[PomodoroSettings] ([Field],[Value]) VALUES ('workTimeMinutes',25);
GO
INSERT INTO [dbo].[PomodoroSettings] ([Field],[Value]) VALUES ('shortBreakTimeMinutes',5);
GO
INSERT INTO [dbo].[PomodoroSettings] ([Field],[Value]) VALUES ('longBreakTimeMinutes',30);
GO
INSERT INTO [dbo].[PomodoroSettings] ([Field],[Value]) VALUES ('longBreakInterval',4);
GO
