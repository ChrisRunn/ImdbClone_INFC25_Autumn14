USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_GetMovieByTitleAndYear]    Script Date: 2014-10-31 08:28:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_GetMovieByTitleAndYear] 
(
	@title VARCHAR(255),
	@year INT
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			SELECT * 
			FROM movie
			WHERE title = @title
				AND [year] = @year
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'There is no data in the table Movie which matches the title and year.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;
GO

