
Create Proc dbo.ListUsers
As
	Select [UID], [UserID], [Password] From Users Order By UID Desc