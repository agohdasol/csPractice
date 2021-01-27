CREATE TABLE [dbo].[Maxims]
(
	[Id]						INT PRIMARY KEY	NOT NULL Identity(1,1),
	[Name]					NVarChar(25)		Not Null,
	[Content]				NVarChar(255)		Null,
	[CreationDate]	DateTime	Default(GetDate())
)
Go