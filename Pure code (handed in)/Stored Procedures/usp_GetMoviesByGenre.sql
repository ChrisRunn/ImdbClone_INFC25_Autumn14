USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_GetMoviesByGenre]    Script Date: 2014-10-31 08:29:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_GetMoviesByGenre]
(
	@genre VARCHAR(255)
)
AS
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			SELECT m.title, m.[year], m.[description], m.[rank]
			FROM Movie m
			INNER JOIN MovieGenre mg
			ON m.title = mg.title
			AND m.[year] = mg.[year]
			WHERE genre = @genre
		END TRY
		BEGIN CATCH
			EXEC usp_ErrorHandling
		END CATCH
	COMMIT
END;
GO

