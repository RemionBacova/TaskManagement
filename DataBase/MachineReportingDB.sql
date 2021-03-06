USE [master]
GO
/****** Object:  Database [MachineReporting]    Script Date: 8/3/2020 5:33:52 PM ******/
CREATE DATABASE [MachineReporting]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MachineReporting', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MachineReporting.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MachineReporting_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MachineReporting_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MachineReporting] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MachineReporting].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MachineReporting] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MachineReporting] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MachineReporting] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MachineReporting] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MachineReporting] SET ARITHABORT OFF 
GO
ALTER DATABASE [MachineReporting] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MachineReporting] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MachineReporting] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MachineReporting] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MachineReporting] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MachineReporting] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MachineReporting] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MachineReporting] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MachineReporting] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MachineReporting] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MachineReporting] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MachineReporting] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MachineReporting] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MachineReporting] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MachineReporting] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MachineReporting] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MachineReporting] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MachineReporting] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MachineReporting] SET  MULTI_USER 
GO
ALTER DATABASE [MachineReporting] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MachineReporting] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MachineReporting] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MachineReporting] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MachineReporting] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MachineReporting', N'ON'
GO
ALTER DATABASE [MachineReporting] SET QUERY_STORE = OFF
GO
USE [MachineReporting]
GO
/****** Object:  Table [dbo].[tbl_MachineReporting]    Script Date: 8/3/2020 5:33:53 PM ******/
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
	[GUID] [varchar](255) NULL,
 CONSTRAINT [PK_tbl_MachineReporting] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Machines]    Script Date: 8/3/2020 5:33:53 PM ******/
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
/****** Object:  StoredProcedure [dbo].[spi_tbl_MachineReporting]    Script Date: 8/3/2020 5:33:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spi_tbl_MachineReporting] ( 

@ProcessName nvarchar(500) = '',
@ApplicationName nvarchar(500) = '',
@TotalSecond int =0 ,       
@MachineHash nvarchar(100) ='',
@SessionID nvarchar(50)='' 

							  
										  )
	                                      
AS 
    
DECLARE @MachineUID int
SET @MachineUID = (select P.UID from tbl_Machines P where P.MachineHash= @MachineHash )


if(select count(*) from [dbo].[tbl_MachineReporting] where [MachineUID]= @MachineUID and [ProcessName] = @ProcessName and ApplicationName = @ApplicationName
and 
(
	Day([CreationDate]) = day(getdate()) and 
	Month([CreationDate]) = Month(getdate()) and 
	Year([CreationDate]) = Year(getdate()) 
) and [GUID]=@SessionID
) > 0
Begin
	update [dbo].[tbl_MachineReporting] set [TotalSecond] = @TotalSecond where [MachineUID]= @MachineUID and [ProcessName] = @ProcessName and ApplicationName = @ApplicationName
	and [GUID]=@SessionID

end
else

	
        BEGIN  
				INSERT INTO [dbo].[tbl_MachineReporting]
					   ([MachineUID]
					   ,[ProcessName]
					   ,[ApplicationName]
					   ,[TotalSecond]
					   ,[CreationDate]
					   ,[GUID])
				VALUES
					   (@MachineUID
					   ,@ProcessName
					   ,@ApplicationName
					   ,@TotalSecond
					   ,getdate()
					   ,@SessionID)

        END 
GO
/****** Object:  StoredProcedure [dbo].[spi_tbl_Machines]    Script Date: 8/3/2020 5:33:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spi_tbl_Machines] ( 
                                          @MachineName   VARCHAR(100),  
                                          @OsVersion    VARCHAR(100),  
                                          @UserDomainName       VArchar(100),  
                                          @UserName      VARCHAR(100),  
										  @Version      VARCHAR(100),
										  @MachineHash varchar(100)

										  )
	                                      
AS  
    
	if((Select COunt(*) from tbl_Machines where @MachineHash = MachineHash ) <1)


	
        BEGIN  

		INSERT INTO [dbo].[tbl_Machines]
           ([MachineName]
           ,[OsVersion]
           ,[UserDomainName]
           ,[UserName]
           ,[Version]
           ,[MachineHash]
           ,[Active]
           ,[CreationDate]
           ,[UserUID])
     VALUES
           (@MachineName
           ,@OsVersion
           ,@UserDomainName
           ,@UserName 
           , @Version
           ,@MachineHash
           ,1
           ,getdate()
           ,1)

        END  
  

GO
USE [master]
GO
ALTER DATABASE [MachineReporting] SET  READ_WRITE 
GO
