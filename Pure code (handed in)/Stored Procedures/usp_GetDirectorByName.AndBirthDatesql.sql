USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_GetDirectorByNameAndBirthdate]    Script Date: 2014-10-31 08:28:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_GetDirectorByNameAndBirthdate]
(
	@name VARCHAR(255),
	@birthdate DATETIME
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			SELECT * 
			FROM Director
			WHERE name  = @name
				AND birthdate = @birthdate
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'There is no data in the table Director.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;
GO

