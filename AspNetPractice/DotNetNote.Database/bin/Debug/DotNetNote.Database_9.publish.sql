/*
DotNetNote의 배포 스크립트

이 코드는 도구를 사용하여 생성되었습니다.
파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
변경 내용이 손실됩니다.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "DotNetNote"
:setvar DefaultFilePrefix "DotNetNote"
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
PRINT N'[dbo].[NoteComments]을(를) 만드는 중...';


GO
CREATE TABLE [dbo].[NoteComments] (
    [Id]        INT             IDENTITY (1, 1) NOT NULL,
    [BoardName] NVARCHAR (50)   NULL,
    [BoardId]   INT             NOT NULL,
    [Name]      NVARCHAR (25)   NOT NULL,
    [Opinion]   NVARCHAR (4000) NOT NULL,
    [PostDate]  SMALLDATETIME   NULL,
    [Password]  NVARCHAR (20)   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'[dbo].[Notes]을(를) 만드는 중...';


GO
CREATE TABLE [dbo].[Notes] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (25)  NOT NULL,
    [Email]        NVARCHAR (100) NULL,
    [Title]        NVARCHAR (150) NOT NULL,
    [PostDate]     DATETIME       NOT NULL,
    [PostIp]       NVARCHAR (15)  NULL,
    [Content]      NTEXT          NOT NULL,
    [Password]     NVARCHAR (20)  NULL,
    [ReadCount]    INT            NULL,
    [Encoding]     NVARCHAR (10)  NOT NULL,
    [Homepage]     NVARCHAR (100) NULL,
    [ModifyDate]   DATETIME       NULL,
    [ModifyIp]     NVARCHAR (15)  NULL,
    [FileName]     NVARCHAR (255) NULL,
    [FileSize]     INT            NULL,
    [DownCount]    INT            NULL,
    [Ref]          INT            NOT NULL,
    [Step]         INT            NULL,
    [RefOrder]     INT            NULL,
    [AnswerNum]    INT            NULL,
    [ParentNum]    INT            NULL,
    [CommentCount] INT            NULL,
    [Category]     NVARCHAR (10)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'[dbo].[NoteComments]에 대한 명명되지 않은 제약 조건을(를) 만드는 중...';


GO
ALTER TABLE [dbo].[NoteComments]
    ADD DEFAULT (GetDate()) FOR [PostDate];


GO
PRINT N'[dbo].[Notes]에 대한 명명되지 않은 제약 조건을(를) 만드는 중...';


GO
ALTER TABLE [dbo].[Notes]
    ADD DEFAULT GetDate() FOR [PostDate];


GO
PRINT N'[dbo].[Notes]에 대한 명명되지 않은 제약 조건을(를) 만드는 중...';


GO
ALTER TABLE [dbo].[Notes]
    ADD DEFAULT 0 FOR [ReadCount];


GO
PRINT N'[dbo].[Notes]에 대한 명명되지 않은 제약 조건을(를) 만드는 중...';


GO
ALTER TABLE [dbo].[Notes]
    ADD DEFAULT 0 FOR [FileSize];


GO
PRINT N'[dbo].[Notes]에 대한 명명되지 않은 제약 조건을(를) 만드는 중...';


GO
ALTER TABLE [dbo].[Notes]
    ADD DEFAULT 0 FOR [DownCount];


GO
PRINT N'[dbo].[Notes]에 대한 명명되지 않은 제약 조건을(를) 만드는 중...';


GO
ALTER TABLE [dbo].[Notes]
    ADD DEFAULT 0 FOR [Step];


GO
PRINT N'[dbo].[Notes]에 대한 명명되지 않은 제약 조건을(를) 만드는 중...';


GO
ALTER TABLE [dbo].[Notes]
    ADD DEFAULT 0 FOR [RefOrder];


GO
PRINT N'[dbo].[Notes]에 대한 명명되지 않은 제약 조건을(를) 만드는 중...';


GO
ALTER TABLE [dbo].[Notes]
    ADD DEFAULT 0 FOR [AnswerNum];


GO
PRINT N'[dbo].[Notes]에 대한 명명되지 않은 제약 조건을(를) 만드는 중...';


GO
ALTER TABLE [dbo].[Notes]
    ADD DEFAULT 0 FOR [ParentNum];


GO
PRINT N'[dbo].[Notes]에 대한 명명되지 않은 제약 조건을(를) 만드는 중...';


GO
ALTER TABLE [dbo].[Notes]
    ADD DEFAULT 0 FOR [CommentCount];


GO
PRINT N'[dbo].[Notes]에 대한 명명되지 않은 제약 조건을(를) 만드는 중...';


GO
ALTER TABLE [dbo].[Notes]
    ADD DEFAULT ('Free') FOR [Category];


GO
PRINT N'업데이트가 완료되었습니다.';


GO
