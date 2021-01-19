
Create Proc dbo.DeleteUsers
	@UID Int
As
	Delete Users Where UID = @UID