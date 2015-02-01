USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_DeleteActor]    Script Date: 2014-10-31 08:23:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_DeleteActor]
(
	@name VARCHAR(255),
	@birthdate DATE
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			DELETE FROM actor
			WHERE name  = @name 
				AND birthdate = @birthdate
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'Unexpected error occured in the procedure "Delete Actor". Please check your values.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;
GO

