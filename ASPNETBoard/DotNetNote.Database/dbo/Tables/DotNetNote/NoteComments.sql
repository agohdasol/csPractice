CREATE TABLE [dbo].[NoteComments]
(
	Id				Int Identity(1,1) Not Null Primary Key,
	BoardName	NVarChar(50) Null,
	BoardId		Int Not Null,
	Name			NVarChar(25) Not Null,
	Opinion		NVarChar(4000) Not Null,
	PostDate	SmallDateTime Default(GetDate()),
	Password	NVarChar(20) Not Null
)
Go