USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_DeleteMovie]    Script Date: 2014-10-31 08:24:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_DeleteMovie] 
(
	@title VARCHAR(255),
	@year INT
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			DELETE FROM movie
			WHERE title = @title 
				AND year = @year
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'Unexpected error occured in the procedure "Delete movie". Please check your values.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;
GO

