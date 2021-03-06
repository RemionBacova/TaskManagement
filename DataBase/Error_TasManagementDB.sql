USE [master]
GO
/****** Object:  Database [Errors_TaskManagement]    Script Date: 8/3/2020 5:33:08 PM ******/
CREATE DATABASE [Errors_TaskManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ERRORS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ERRORS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ERRORS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ERRORS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Errors_TaskManagement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Errors_TaskManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Errors_TaskManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Errors_TaskManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Errors_TaskManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Errors_TaskManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Errors_TaskManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [Errors_TaskManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Errors_TaskManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Errors_TaskManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Errors_TaskManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Errors_TaskManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Errors_TaskManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Errors_TaskManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Errors_TaskManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Errors_TaskManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Errors_TaskManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Errors_TaskManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Errors_TaskManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Errors_TaskManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Errors_TaskManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Errors_TaskManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Errors_TaskManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Errors_TaskManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Errors_TaskManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Errors_TaskManagement] SET  MULTI_USER 
GO
ALTER DATABASE [Errors_TaskManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Errors_TaskManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Errors_TaskManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Errors_TaskManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Errors_TaskManagement] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Errors_TaskManagement', N'ON'
GO
ALTER DATABASE [Errors_TaskManagement] SET QUERY_STORE = OFF
GO
USE [Errors_TaskManagement]
GO
/****** Object:  Table [dbo].[tbl_ERRORS]    Script Date: 8/3/2020 5:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ERRORS](
	[UID] [int] IDENTITY(1,1) NOT NULL,
	[ERRORTYPE_UID] [int] NULL,
	[LOG_UID] [int] NULL,
	[CREATION_DATE] [datetime] NOT NULL,
 CONSTRAINT [PK_tbl_ERRORS] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ERRORTYPE]    Script Date: 8/3/2020 5:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ERRORTYPE](
	[UID] [int] IDENTITY(1,1) NOT NULL,
	[UID_GEN] [nvarchar](50) NOT NULL,
	[ERRORNAME] [nvarchar](max) NULL,
	[ERRORDESCRIPTION] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbl_ERRORTYPE] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 70, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_LOGS]    Script Date: 8/3/2020 5:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_LOGS](
	[UID] [int] IDENTITY(1,1) NOT NULL,
	[NAME_SP] [nvarchar](50) NULL,
	[PARAMETERS] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbl_LOGS] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 70, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_ERRORS]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ERRORS_tbl_ERRORTYPE] FOREIGN KEY([ERRORTYPE_UID])
REFERENCES [dbo].[tbl_ERRORTYPE] ([UID])
GO
ALTER TABLE [dbo].[tbl_ERRORS] CHECK CONSTRAINT [FK_tbl_ERRORS_tbl_ERRORTYPE]
GO
ALTER TABLE [dbo].[tbl_ERRORS]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ERRORS_tbl_LOGS] FOREIGN KEY([LOG_UID])
REFERENCES [dbo].[tbl_LOGS] ([UID])
GO
ALTER TABLE [dbo].[tbl_ERRORS] CHECK CONSTRAINT [FK_tbl_ERRORS_tbl_LOGS]
GO
/****** Object:  StoredProcedure [dbo].[select_Error]    Script Date: 8/3/2020 5:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[select_Error]
(
@error_id as int
)
as
	select tbl_ERRORTYPE.UID, tbl_ERRORTYPE.ERRORDESCRIPTION as ErrorName from tbl_ERRORS 
inner join tbl_ERRORTYPE on tbl_ERRORS.[ERRORTYPE_UID] = tbl_ERRORTYPE.[UID]
inner join tbl_LOGS on tbl_LOGS.[UID] = tbl_ERRORS.LOG_UID
where tbl_ERRORS.[UID] =@error_id


GO
/****** Object:  StoredProcedure [dbo].[select_OK]    Script Date: 8/3/2020 5:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[select_OK]

as
	select  tbl_ERRORTYPE.UID, tbl_ERRORTYPE.ERRORDESCRIPTION  from tbl_ERRORTYPE where uid = 17


GO
/****** Object:  StoredProcedure [dbo].[spI_tbl_ERRORS]    Script Date: 8/3/2020 5:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[spI_tbl_ERRORS]
(
  @log_uid [int]= Null,
  @errorname nvarchar(50) = ''

)
As
declare @error_uid as int;
SET  @error_uid = (SELECT [UID] FROM [dbo].[tbl_ERRORTYPE] WHERE [ERRORNAME] like @errorname);

		Insert Into [dbo].[tbl_ERRORS]
		(
			[LOG_UID],-- log id
			[ERRORTYPE_UID],-- type error id
			[CREATION_DATE]
			 
          
		)
		Values
		(
			
			@log_uid,--logi id
			@error_uid,-- type error id
			(getdate())
		);
 return @@IDENTITY;
GO
/****** Object:  StoredProcedure [dbo].[spI_tbl_LOGS]    Script Date: 8/3/2020 5:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[spI_tbl_LOGS]
(
  @name_sp [varchar](500) = Null
, @parameters [varchar](max) = Null

)
As

		Insert Into [dbo].[tbl_LOGS]
		(
			[NAME_SP],
			[PARAMETERS]
          
		)
		Values
		(
			
			@name_sp,
			@parameters
		)

return @@identity;
GO
USE [master]
GO
ALTER DATABASE [Errors_TaskManagement] SET  READ_WRITE 
GO
