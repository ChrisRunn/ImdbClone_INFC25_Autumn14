USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_GetAllMovies]    Script Date: 2014-10-31 08:26:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_GetAllMovies]
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			SELECT * FROM movie
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'There is no data in the table movie.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;
GO

