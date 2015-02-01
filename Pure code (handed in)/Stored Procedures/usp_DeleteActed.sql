USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_DeleteActed]    Script Date: 2014-10-31 08:23:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_DeleteActed]
(
	@name VARCHAR(255),
	@birthdate DATE,
	@title VARCHAR(255),
	@year INT
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			DELETE FROM acted
			WHERE name = @name
				AND birthdate = @birthdate 
				AND title = @title 
				AND year = @year
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'Unexpected error occured in the procedure "Delete Acted". Please check your values.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;
GO

