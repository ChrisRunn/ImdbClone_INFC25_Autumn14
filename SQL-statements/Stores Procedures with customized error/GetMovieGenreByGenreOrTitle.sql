USE [imdbclone]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetMovieGenreByGenreOrTitle]    Script Date: 2014-10-30 09:00:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetMovieGenreByGenreOrTitle]
(
	@searchString VARCHAR(255)
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			SELECT * 
			FROM MovieGenre 
			WHERE genre like '%' + @searchString  + '%' or title like '%' + @searchString  + '%'
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'There is no data in the table MovieGenre which matches the searchstring.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;
