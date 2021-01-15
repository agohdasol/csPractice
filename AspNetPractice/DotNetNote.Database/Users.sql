CREATE TABLE [dbo].[Users]
(
	UID INT Identity(1,1) PRIMARY KEY Not Null,
	UserID NVARChar(25) Not Null,
	[Password] NVarChar(20) Not Null,
)
Go