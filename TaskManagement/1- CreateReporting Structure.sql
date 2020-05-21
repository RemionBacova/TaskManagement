USE [TaskManagement]
GO
/****** Object:  Table [dbo].[tbl_MachineReporting]    Script Date: 21/05/2020 10:24:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MachineReporting](
	[UID] [int] IDENTITY(1,1) NOT NULL,
	[MachineUID] [int] NOT NULL,
	[ProcessName] [nvarchar](100) NULL,
	[ApplicationName] [nvarchar](100) NULL,
	[TotalSecond] [int] NULL,
	[CreationDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_MachineReporting] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Machines]    Script Date: 21/05/2020 10:24:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Machines](
	[UID] [int] IDENTITY(1,1) NOT NULL,
	[MachineName] [nvarchar](100) NULL,
	[OsVersion] [nvarchar](100) NULL,
	[UserDomainName] [nvarchar](100) NULL,
	[UserName] [nvarchar](100) NULL,
	[Version] [nvarchar](100) NULL,
	[MachineHash] [nvarchar](100) NULL,
	[Active] [bit] NULL,
	[CreationDate] [datetime] NULL,
	[UserUID] [int] NULL,
 CONSTRAINT [PK_tbl_Machines] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_MachineReporting]  WITH CHECK ADD  CONSTRAINT [FK_tbl_MachineReporting_tbl_Machines] FOREIGN KEY([MachineUID])
REFERENCES [dbo].[tbl_Machines] ([UID])
GO
ALTER TABLE [dbo].[tbl_MachineReporting] CHECK CONSTRAINT [FK_tbl_MachineReporting_tbl_Machines]
GO
