CREATE PROCEDURE [dbo].[DNN_GetCountNotes]
AS
	SELECT Count(*) From Notes
Go
