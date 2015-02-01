USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_DeleteDirected]    Script Date: 2014-10-31 08:23:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_DeleteDirected]
(
	@name NVARCHAR(255),
	@birthdate DATE, 
	@title VARCHAR(255),
	@year INT
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			DELETE FROM directed
			WHERE name = @name
				AND birthdate= @birthdate
				AND title = @title 
				AND year = @year
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'Unexpected error occured in the procedure "Delete directed". Please check your values.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;
GO

