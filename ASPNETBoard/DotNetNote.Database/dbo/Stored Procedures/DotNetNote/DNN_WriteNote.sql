CREATE PROCEDURE [dbo].[DNN_WriteNote]
	@Name			NVarChar(25),
	@Email		NVarChar(100),
	@Title		NVarChar(150),
	@PostIp		NVarChar(15),
	@Content	NText,
	@Password	NVarChar(20),
	@Encoding	NVarChar(10),
	@Homepage	NVarChar(100),
	@FileName	NVarChar(255),
	@FileSize	Int
AS
	Declare @MaxRef Int
	SELECT @MaxRef = Max(Ref) From Notes
	If @MaxRef is Null
		Set @MaxRef = 1
	Else
		Set @MaxRef = @MaxRef+1

	Insert Notes
	(
		Name, Email, Title, PostIp, Content, Password, Encoding, Homepage, Ref, FileName, FileSize
	)
	Values
	(
		@Name, @Email, @Title, @PostIp, @Content, @Password, @Encoding, @Homepage, @MaxRef, @FileName, @FileSize
	)
Go
