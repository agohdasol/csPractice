
Create Proc dbo.ViewUser
	@UID Int
As
	Select [UID], [UserID], [Password] From Users Where UID = @UID