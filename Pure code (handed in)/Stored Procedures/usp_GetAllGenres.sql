USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_GetAllGenres]    Script Date: 2014-10-31 08:26:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_GetAllGenres]
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			SELECT * FROM genre
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'There is no data in the table Genre.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;
GO

