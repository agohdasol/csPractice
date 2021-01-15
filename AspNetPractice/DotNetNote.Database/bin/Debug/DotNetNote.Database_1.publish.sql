/*
DevADONET의 배포 스크립트

이 코드는 도구를 사용하여 생성되었습니다.
파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
변경 내용이 손실됩니다.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "DevADONET"
:setvar DefaultFilePrefix "DevADONET"
:setvar DefaultDataPath "C:\Users\agohd\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\agohd\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
SQLCMD 모드가 지원되지 않으면 SQLCMD 모드를 검색하고 스크립트를 실행하지 않습니다.
SQLCMD 모드를 설정한 후에 이 스크립트를 다시 사용하려면 다음을 실행합니다.
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'이 스크립트를 실행하려면 SQLCMD 모드를 사용하도록 설정해야 합니다.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'[dbo].[Users]을(를) 만드는 중...';


GO
CREATE TABLE [dbo].[Users] (
    [UID]      INT           IDENTITY (1, 1) NOT NULL,
    [UserID]   NVARCHAR (25) NOT NULL,
    [Password] NVARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([UID] ASC)
);


GO
PRINT N'[dbo].[DeleteUsers]을(를) 만드는 중...';


GO

Create Proc dbo.DeleteUsers
	@UID Int
As
	Delete Users Where UID = @UID
GO
PRINT N'[dbo].[ListUsers]을(를) 만드는 중...';


GO

Create Proc dbo.ListUsers
As
	Select [UID], [UserID], [Password] From Users Order By UID Desc
GO
PRINT N'[dbo].[ModifyUsers]을(를) 만드는 중...';


GO

Create Proc dbo.ModifyUsers
	@UserID NVarChar(25),
	@Password NVarChar(20),
	@UID Int
As
	Begin Tran
		Update Users
		Set
			UserID = @UserID,
			[Password] = @Password
		Where UID = @UID
	Commit Tran
GO
PRINT N'[dbo].[SearchUsers]을(를) 만드는 중...';


GO

Create Proc dbo.SearchUsers
	@SearchField NVarChar(25),
	@SearchQuery NVarChar(25)
As
	Declare @strSql NVarChar(255)
	Set @strSql = '
		Select * From Users
		Where
			' + @SearchField + ' Liked ''%' + @SearchQuery + '%''
	'
	Exec(@strSql)
GO
PRINT N'[dbo].[ViewUser]을(를) 만드는 중...';


GO

Create Proc dbo.ViewUser
	@UID Int
As
	Select [UID], [UserID], [Password] From Users Where UID = @UID
GO
PRINT N'[dbo].[WriteUsers]을(를) 만드는 중...';


GO
Create Proc dbo.WriteUsers
	@UserID NVarChar(25),
	@Password NVarChar(20)
As 
	Insert Into Users Values(@UserID, @Password)
GO
PRINT N'업데이트가 완료되었습니다.';


GO
