
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