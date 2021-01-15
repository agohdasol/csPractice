CREATE TABLE [dbo].[Users]
(
	UID INT Identity(1,1) PRIMARY KEY NOT NULL,
	UserID NVarChar(25) Not Null,
	[Password] NVarChar(20) Not Null,
)
Go