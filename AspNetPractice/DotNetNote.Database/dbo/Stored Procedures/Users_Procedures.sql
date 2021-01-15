Create Proc dbo.WriteUsers
	@UserID NVarChar(25),
	@Password NVarChar(20)
As 
	Insert Into Users Values(@UserID, @Password)
Go

Create Proc dbo.ListUsers
As
	Select [UID], [UserID], [Password] From Users Order By UID Desc
Go

Create Proc dbo.ViewUser
	@UID Int
As
	Select [UID], [UserID], [Password] From Users Where UID = @UID
Go

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
Go

Create Proc dbo.DeleteUsers
	@UID Int
As
	Delete Users Where UID = @UID
Go

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
Go