CREATE PROCEDURE [dbo].[ViewNote]
	@Id Int
AS
	Update Notes Set ReadCount = ReadCount + 1 Where Id = @Id

	Select * From Notes Where Id = @Id