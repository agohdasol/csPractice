﻿/*
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
PRINT N'[dbo].[DeleteUsers] 변경 중...';


GO
--ModifyUsers 'master', '1234', 2


--[5] 삭제 저장 프로시저
ALTER Proc dbo.DeleteUsers
	@UID Int
As
	Delete Users Where UID = @UID
GO
PRINT N'[dbo].[ListUsers] 변경 중...';


GO
--WriteUsers 'redplus', '1234'


--[2] 출력 저장 프로시저
--Create Proc dbo.ListUsers
--As
--	Select * From Users Order By UID Desc
--Go
ALTER Proc dbo.ListUsers
As
	Select [UID], [UserID], [Password] From Users Order By UID Desc
GO
PRINT N'[dbo].[ModifyUsers] 변경 중...';


GO
--ViewUsers 5


--[4] 수정 저장 프로시저
ALTER Proc dbo.ModifyUsers
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
PRINT N'[dbo].[SearchUsers] 변경 중...';


GO
--DeleteUsers 2


--[6] 검색 저장 프로시저
ALTER Proc dbo.SearchUsers
	@SearchField NVarChar(25),
	@SearchQuery NVarChar(25)
As
	Declare @strSql NVarChar(255)
	Set @strSql = '
		Select * From Users 
		Where 
			' + @SearchField + ' Like ''%' + @SearchQuery + '%''
	'
	-- Print @strSql
	Exec(@strSql)
GO
PRINT N'[dbo].[WriteUsers] 변경 중...';


GO
--[User][0][2] Users 관련 저장 프로시저 생성

--[1] 입력 저장 프로시저
ALTER Proc dbo.WriteUsers
	@UserID NVarChar(25),
	@Password NVarChar(20)
As
	Insert Into Users Values(@UserID, @Password)
GO
PRINT N'[dbo].[DeleteNote]을(를) 만드는 중...';


GO
--[7] 해당 글을 지우는 저장 프로시저: 답변글이 있으면 업데이트하고 없으면 지운다.
Create Proc dbo.DeleteNote
    @Id Int,
    @Password NVarChar(30) -- 암호 매개변수 추가
As
    Declare @cnt Int
    Select @cnt = Count(*) From Notes
    Where Id = @Id And Password = @Password

    If @cnt = 0
    Begin
        Return 0 -- 번호와 암호가 맞는게 없으면 0을 반환
    End	

    Declare @AnswerNum Int
    Declare @RefOrder Int
    Declare @Ref Int
    Declare @ParentNum Int

    Select
        @AnswerNum = AnswerNum,     @RefOrder = RefOrder,
        @Ref = Ref,                 @ParentNum = ParentNum
    From Notes
    Where Id = @Id

    If @AnswerNum = 0
    Begin
        If @RefOrder > 0 
        Begin
            UPDATE Notes SET RefOrder = RefOrder - 1
            WHERE Ref = @Ref AND RefOrder > @RefOrder
            UPDATE Notes SET AnswerNum = AnswerNum - 1 WHERE Id = @ParentNum
        End
        Delete Notes Where Id = @Id
        Delete Notes 
        WHERE 
            Id = @ParentNum AND ModifyIp = N'((DELETED))' AND AnswerNum = 0	
    End
    Else
    Begin
        Update Notes 
        Set 
            Name = N'(Unknown)', Email = '', Password = '',
            Title = N'(삭제된 글입니다.)', 
            Content = N'(삭제된 글입니다. ' 
            + N'현재 답변이 포함되어 있기 때문에 내용만 삭제되었습니다.)',
            ModifyIp = N'((DELETED))', FileName = '', 
            FileSize = 0, CommentCount = 0
        Where Id = @Id  
    End
GO
PRINT N'[dbo].[GetCountNotes]을(를) 만드는 중...';


GO
--[5] DotNetNote 테이블에 있는 레코드의 개수를 구하는 저장 프로시저
Create Proc dbo.GetCountNotes
As
    Select Count(*) From Notes
GO
PRINT N'[dbo].[ListNotes]을(를) 만드는 중...';


GO
--[2] 게시판(DotNetNote)에서 데이터 출력 : ListNotes
Create Procedure dbo.ListNotes
    @Page Int
As
    With DotNetNoteOrderedLists 
    As 
    (
        Select 
            [Id], [Name], [Email], [Title], [PostDate], [ReadCount], 
            [Ref], [Step], [RefOrder], [AnswerNum], [ParentNum], 
            [CommentCount], [FileName], [FileSize], [DownCount], 
            ROW_NUMBER() Over (Order By Ref Desc, RefOrder Asc) 
            As 'RowNumber' 
        From Notes
    ) 
    Select * From DotNetNoteOrderedLists 
    Where RowNumber Between @Page * 10 + 1 And (@Page + 1) * 10
GO
PRINT N'[dbo].[ModifyNote]을(를) 만드는 중...';


GO
--[8] 해당 글을 수정하는 저장 프로시저 : ModifyNote
Create Proc dbo.ModifyNote
    @Name       NVarChar(25), 
    @Email      NVarChar(100), 
    @Title      NVarChar(150), 
    @ModifyIp   NVarChar(15), 
    @Content    NText,
    @Password   NVarChar(30), 
    @Encoding   NVarChar(10), 
    @Homepage   NVarChar(100),
    @FileName	NVarChar(255),
    @FileSize	Int,
    
    @Id Int
As
    Declare @cnt Int

    Select @cnt = Count(*) From Notes 
    Where Id = @Id And Password = @Password

    If @cnt > 0 -- 번호와 암호가 맞는게 있다면...
    Begin
        Update Notes 
        Set 
            Name = @Name, Email = @Email, Title = @Title,
            ModifyIp = @ModifyIp, ModifyDate = GetDate(),
            Content = @Content, Encoding = @Encoding,
            Homepage = @Homepage, FileName = @FileName, FileSize = @FileSize
        Where Id = @Id

        Select '1'
    End
    Else
        Select '0'
GO
PRINT N'[dbo].[ReplyNote]을(를) 만드는 중...';


GO
--[4] 게시판(DotNetNote)에 글을 답변 : ReplyNote
Create Proc dbo.ReplyNote
    @Name       NVarChar(25), 
    @Email      NVarChar(100), 
    @Title      NVarChar(150), 
    @PostIp     NVarChar(15), 
    @Content    NText, 
    @Password   NVarChar(20), 
    @Encoding   NVarChar(10), 
    @Homepage   NVarChar(100),
    @ParentNum  Int,                -- 부모글의 고유번호(Id)
    @FileName   NVarChar(255),
    @FileSize   Int
As
    --[0] 변수 선언
    Declare @MaxRefOrder Int
    Declare @MaxRefAnswerNum Int
    Declare @ParentRef Int
    Declare @ParentStep Int
    Declare @ParentRefOrder Int

    --[1] 부모글의 답변수(AnswerNum)를 1증가
    Update Notes Set AnswerNum = AnswerNum + 1 Where Id = @ParentNum 

    --[2] 같은 글에 대해서 답변을 두 번 이상하면 먼저 답변한 게 위에 나타나게 한다.
    Select @MaxRefOrder = RefOrder, @MaxRefAnswerNum = AnswerNum From Notes 
    Where 
        ParentNum = @ParentNum And 
        RefOrder = 
            (Select Max(RefOrder) From Notes Where ParentNum = @ParentNum)

    If @MaxRefOrder Is Null
    Begin
        Select @MaxRefOrder = RefOrder From Notes Where Id = @ParentNum
        Set @MaxRefAnswerNum = 0  
    End 

    --[3] 중간에 답변달 때(비집고 들어갈 자리 마련)
    Select 
        @ParentRef = Ref, @ParentStep = Step 
    From Notes Where Id = @ParentNum

    Update Notes 
    Set 
        RefOrder = RefOrder + 1 
    Where 
        Ref = @ParentRef And RefOrder > (@MaxRefOrder + @MaxRefAnswerNum)

    --[4] 최종저장
    Insert Notes
    (
        Name, Email, Title, PostIp, Content, Password, Encoding, 
        Homepage, Ref, Step, RefOrder, ParentNum, FileName, FileSize
    )
    Values
    (
        @Name, @Email, @Title, @PostIp, @Content, @Password, @Encoding, 
        @Homepage, @ParentRef, @ParentStep + 1, 
        @MaxRefOrder + @MaxRefAnswerNum + 1, @ParentNum, @FileName, @FileSize
    )
GO
PRINT N'[dbo].[SearchNoteCount]을(를) 만드는 중...';


GO
--[6] 검색 결과의 레코드 수 반환
Create Proc dbo.SearchNoteCount
    @SearchField NVarChar(25),
    @SearchQuery NVarChar(25)
As
    Set @SearchQuery = '%' + @SearchQuery + '%'

    Select Count(*)
    From Notes
    Where
    (
        Case @SearchField 
            When 'Name' Then [Name]
            When 'Title' Then Title
            When 'Content' Then Content
            Else @SearchQuery
        End
    ) 
    Like 
    @SearchQuery
GO
PRINT N'[dbo].[SearchNotes]을(를) 만드는 중...';


GO
--[9] 게시판(DotNetNote)에서 데이터 검색 리스트 : SearchNotes
Create Procedure dbo.SearchNotes
    @Page Int,
    @SearchField NVarChar(25),
    @SearchQuery NVarChar(25)
As
    With DotNetNoteOrderedLists 
    As 
    (
        Select 
            [Id], [Name], [Email], [Title], [PostDate], 
            [ReadCount], [Ref], [Step], [RefOrder], [AnswerNum], 
            [ParentNum], [CommentCount], [FileName], [FileSize], 
            [DownCount], 
            ROW_NUMBER() Over (Order By Ref Desc, RefOrder Asc) 
            As 'RowNumber' 
        From Notes
        Where ( 
            Case @SearchField 
                When 'Name' Then [Name] 
                When 'Title' Then Title 
                When 'Content' Then Content 
                Else 
                @SearchQuery 
            End 
        ) Like '%' + @SearchQuery + '%'
    ) 
    Select 
        [Id], [Name], [Email], [Title], [PostDate], 
        [ReadCount], [Ref], [Step], [RefOrder], 
        [AnswerNum], [ParentNum], [CommentCount], 
        [FileName], [FileSize], [DownCount], 
        [RowNumber] 
    From DotNetNoteOrderedLists 
    Where RowNumber Between @Page * 10 + 1 And (@Page + 1) * 10  
    Order By Id Desc
GO
PRINT N'[dbo].[ViewNote]을(를) 만드는 중...';


GO
--[3] 해당 글을 세부적으로 읽어오는 저장 프로시저 : ViewNote
Create Procedure dbo.ViewNote
    @Id Int
As
    -- 조회수 카운트 1증가
    Update Notes Set ReadCount = ReadCount + 1 Where Id = @Id
    
    -- 모든 항목 조회
    Select * From Notes Where Id = @Id
GO
PRINT N'[dbo].[ViewUsers]을(를) 만드는 중...';


GO
--ListUsers


--[3] 상세 저장 프로시저
Create Proc dbo.ViewUsers
	@UID Int
As
	Select [UID], [UserID], [Password] From Users Where UID = @UID
GO
PRINT N'[dbo].[WriteNote]을(를) 만드는 중...';


GO
--[1] 게시판(DotNetNote)에 글을 작성 : WriteNote
Create Proc dbo.WriteNote
    @Name       NVarChar(25), 
    @Email      NVarChar(100), 
    @Title      NVarChar(150), 
    @PostIp     NVarChar(15), 
    @Content    NText, 
    @Password   NVarChar(20), 
    @Encoding   NVarChar(10), 
    @Homepage   NVarChar(100),
    @FileName   NVarChar(255),
    @FileSize   Int
As
    Declare @MaxRef Int
    Select @MaxRef = Max(Ref) From Notes
 
    If @MaxRef is Null
        Set @MaxRef = 1 -- 테이블 생성 후 처음만 비교
    Else
        Set @MaxRef = @MaxRef + 1

    Insert Notes
    (
        Name, Email, Title, PostIp, Content, Password, Encoding, 
        Homepage, Ref, FileName, FileSize
    )
    Values
    (
        @Name, @Email, @Title, @PostIp, @Content, @Password, @Encoding, 
        @Homepage, @MaxRef, @FileName, @FileSize
    )
GO
PRINT N'업데이트가 완료되었습니다.';


GO