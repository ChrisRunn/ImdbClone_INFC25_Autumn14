USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_GetAllGenresForMovie]    Script Date: 2014-10-31 08:26:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_GetAllGenresForMovie]
(
	@title NVARCHAR(255),
	@year INT	
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			SELECT g.name
			FROM Genre g
			INNER JOIN MovieGenre mg
			ON g.name = mg.genre
			WHERE mg.title = @title
				AND mg.[year] = @year
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'There are no movies which matches the genre.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END
GO

