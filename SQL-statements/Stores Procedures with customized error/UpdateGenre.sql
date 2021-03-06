USE [imdbclone]
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateGenre]    Script Date: 2014-10-30 09:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UpdateGenre] 
(
	@name VARCHAR(255),
	@oldName VARCHAR(255)
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			UPDATE genre
			SET name = @name
			WHERE name = @oldName
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'Unexpected error occured in the procedure "Update Genre". Please check your values.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;