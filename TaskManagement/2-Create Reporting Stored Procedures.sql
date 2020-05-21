GO
/****** Object:  StoredProcedure [dbo].[spi_tbl_MachineReporting]    Script Date: 21/05/2020 10:26:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[spi_tbl_MachineReporting] ( 

@ProcessName nvarchar(50),
@ApplicationName nvarchar(14),
@TotalSecond nvarchar(10),       
@MachineHash nvarchar(100)

							  
										  )
	                                      
AS 
    
DECLARE @MachineUID int
SET @MachineUID = (select P.UID from tbl_Machines P where P.MachineHash= @MachineHash )


	
        BEGIN  
				INSERT INTO [dbo].[tbl_MachineReporting]
					   ([MachineUID]
					   ,[ProcessName]
					   ,[ApplicationName]
					   ,[TotalSecond]
					   ,[CreationDate])
				VALUES
					   (@MachineUID
					   ,@ProcessName
					   ,@ApplicationName
					   ,@TotalSecond
					   ,getdate())

        END  
  
GO
/****** Object:  StoredProcedure [dbo].[spi_tbl_Machines]    Script Date: 21/05/2020 10:26:00 AM ******/
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
