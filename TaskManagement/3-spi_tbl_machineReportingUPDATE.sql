USE [TaskManagement]
GO
/****** Object:  StoredProcedure [dbo].[spi_tbl_MachineReporting]    Script Date: 5/27/2020 10:00:23 AM ******/
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
