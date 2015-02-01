USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_GetMovieByTitle]    Script Date: 2014-10-31 08:28:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_GetMovieByTitle] 
(
	@title VARCHAR(255)
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			SELECT * 
			FROM movie
			WHERE title LIKE '%' + @title + '%'
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'There is no data in the table Movie which matches the title.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;
GO

