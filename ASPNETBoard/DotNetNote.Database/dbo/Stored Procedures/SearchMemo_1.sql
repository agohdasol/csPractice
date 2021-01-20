
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
