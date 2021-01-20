CREATE TABLE [dbo].[Notes]
(
	Id						INT Identity(1,1) Not Null Primary Key,	--번호
	Name					NVarChar(25) Not Null,									--이름
	Email					NVarChar(100) Null,											--이메일
	Title					NVarChar(150) Not Null,
	PostDate			DateTime Default GetDate() Not Null,
	PostIp				NVarChar(15) Null,
	Content				NText Not Null,
	Password			NVarChar(20) Null,
	ReadCount			Int Default 0,
	Encoding			NVarChar(10) Not Null,
	Homepage			NVarChar(100) Null,
	ModifyDate		DateTime Null,
	ModifyIp			NVarChar(15) Null,
	FileName			NVarChar(255) Null,
	FileSize			Int Default 0,
	DownCount			Int Default 0,
	Ref						Int Not Null,
	Step					Int Default 0,
	RefOrder			Int Default 0,
	AnswerNum			Int Default 0,
	ParentNum			Int Default 0,
	CommentCount	Int Default 0,
	Category			NVarChar(10) Null
)
Go