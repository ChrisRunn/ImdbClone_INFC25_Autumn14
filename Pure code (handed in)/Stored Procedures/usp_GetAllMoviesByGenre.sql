USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_GetAllMoviesByGenre]    Script Date: 2014-10-31 08:26:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_GetAllMoviesByGenre]
(
	@name VARCHAR(255)
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY

			SELECT m.title, m.[year], m.[description], m.[rank]
			FROM Movie m
			INNER JOIN MovieGenre g
			ON m.title = g.title
			AND m.[year] = g.[year]
			WHERE genre = @name 

		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'There are no movies which matches the genre.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;

GO

