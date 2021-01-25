Create Proc dbo.WriteUsers
	@UserID NVarChar(25),
	@Password NVarChar(20)
As 
	Insert Into Users Values(@UserID, @Password)