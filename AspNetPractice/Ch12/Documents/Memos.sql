--테이블 설계
Create Table dbo.Memos
(
	Num			Int Identity(1, 1) Primary Key,			--번호
	Name		NVarChar(25) Not Null,					--이름
	Email		NVarChar(100) Null,						--이메일
	Title		NVarChar(150) Not Null,					--메모
	PostDate	DateTime Default(GetDate()),			--작성일
	PostIP		NVarChar(15) Null						--IP 주소
)

--입력 예시문
Insert Memos
Values
(
	N'레드플러스', N'redplus@devlec.com', N'레드플러스입니다.'
	, GetDate(), '127.0.0.1'
)
Go

--출력예시문
Select Num, Name, Email, Title, PostDate, PostIP
From Memos Order By Num Desc
Go

--상세예시문
Select Num, Name, Email, Title, PostDate, PostIP
From Memos Where Num = 1
Go

--수정예시문
Begin Tran
	Update Memos
	Set
		Name = N'백두산',
		Email = N'admin@devlec.com',
		Title = N'백두산입니다.',
		PostIP = N'127.0.0.1'
	Where
		Num = 1
--RollBack Tran
Commit Tran
Go

--삭제예시문
Begin Tran
	Delete Memos
	Where Num = 10
--RollBack Tran
Commit Tran
Go

--검색예시문
--Memos에서 이름이 레드플러스이거나
--이메일에 'r'이 들어가는 자료의 모든 필드
--번호의 역순으로 검색
Select Num, Name, Email, Title, PostDate
From Memos
Where
	Name = '레드플러스'
	Or
	Email Like '%r%'
Order By Num Desc
Go

--메모 입력용 저장 프로시저
Create Procedure dbo.WriteMemo
(
	@Name NVarChar(25),
	@Email NVarChar(100),
	@Title NVarChar(150),
	@PostIP NVarChar(15)
)
As
	Insert Memos(Name, Email, Title, PostIP)
	Values(@Name, @Email, @Title, @PostIP)
Go

--메모 출력용 저장 프로시저
Create Proc dbo.ListMemo
As
	Select Num, Name, Email, Title, PostDate, PostIP
	From Memos Order By Num Desc
Go

--메모 상세보기용 저장 프로시저
Create Proc dbo.ViewMemo
(
	@Num Int
)
As
	Select Num, Name, Email, Title, PostDate, PostIP
	From Memos
	Where Num = @Num
Go

--메모 데이터 수정용 저장 프로시저
Create Proc dbo.ModifyMemo
(
	@Name NVarChar(25),
	@Email NVarChar(100),
	@Title NVarChar(150),
	@Num Int
)
As
Begin Transaction
	Update Memos
	Set
		Name = @Name,
		Email = @Email,
		Title = @Title
	Where Num = @Num
Commit Transaction
Go

--메모 데이터
Create Proc dbo.DeleteMemo
(
	@Num Int
)
As
	Delete Memos
	Where Num = @Num
Go

--메모 데이터 검색용 저장 프로시저(동적 SQL 사용)
Create Proc dbo.SearchMemo
(
	@SearchField NVarChar(10),
	@SearchQuery NVarChar(50)
)
--With Encryption -- 현재 SP문 암호화
As
	Declare @strSql NVarChar(150)
	Set @strSql =
		'
		Select Num, Name, Email, Title, PostDate, PostIP
		From Memos
		Where ' + @SearchField + ' Like
			N''%' + @SearchQuery + '%''
		Order By Num Desc
		'
	--Print @strSql
	Exec (@strSql)
Go