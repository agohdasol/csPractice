CREATE TABLE [dbo].[CommunityCampJoinMembers]
(
  [Id] INT NOT NULL PRIMARY KEY Identity(1,1),
  [CommunityName] NVarChar(25) Not Null,
  [Name] NVarChar(25) Not Null,
  [Mobile] NVarChar(30) Not Null,
  [Email] NVarChar(100) Not Null,
  [Size] NVarChar(10) Not Null Default('L'),
  [CreationDate] DateTime Default(GetDate())
)
Go