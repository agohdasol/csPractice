CREATE PROCEDURE [dbo].[ReplyNote]
	@Name				NVarChar(25),
	@Email			NVarChar(100),
	@Title			NVarChar(150),
	@PostIp			NVarChar(15),
	@Content		NText,
	@Password		NVarChar(20),
	@Encoding		NVarChar(10),
	@Homepage		NVarChar(100),
	@ParentNum	Int,
	@FileName		NVarChar(255),
	@FileSize		Int
AS
	Declare @MaxRefOrder Int
	Declare @MaxRefAnswerNum Int
	Declare @ParentRef Int
	Declare @ParentStep Int
	Declare @ParentRefOrder Int

	Update Notes Set AnswerNum = AnswerNum + 1 Where Id = @ParentNum

	Select @MaxRefOrder = RefOrder, @MaxRefAnswerNum = AnswerNum From Notes
	Where
		ParentNum = @ParentNum And
		RefOrder = (Select Max(RefOrder) From Notes Where ParentNum = @ParentNum)

	If @MaxRefOrder Is Null
	Begin
		Select @MaxRefOrder = RefOrder From Notes Where Id = @ParentNum
		Set @MaxRefAnswerNum = 0
	End

	Select
		@ParentRef = Ref, @ParentStep = Step
	From Notes Where Id = @ParentNum

	Update Notes
	Set
		RefOrder = RefOrder + 1
	Where
		Ref = @ParentRef And RefOrder > (@MaxRefOrder + @MaxRefAnswerNum)

	Insert Notes
	(
		Name, Email, Title, PostIp, Content, Password, Encoding, Homepage, Ref, Step,
		RefOrder, ParentNum, FileName, FileSize
	)
	Values
	(
		@Name, @Email, @Title, @PostIp, @Content, @Password, @Encoding, @Homepage, @ParentRef, @ParentStep + 1,
		@MaxRefOrder + @MaxRefAnswerNum + 1, @ParentNum, @FileName, @FileSize
	)