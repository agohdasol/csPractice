CREATE PROCEDURE [dbo].[SearchNoteCount]
	@SearchField NVarChar(25),
	@SearchQuery NVarChar(25)
AS
	Set @SearchQuery = '%' + @SearchQuery + '%'

	SELECT Count(*)
	From Notes
	Where
	(
		Case @SearchField
			When 'Name' Then [Name]
			When 'Tltle' Then Title
			When 'Content' Then Content
			Else @SearchQuery
		End
	)
	Like
	@SearchQuery