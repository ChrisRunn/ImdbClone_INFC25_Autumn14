USE [imdbclone]
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteDirector]    Script Date: 2014-10-30 08:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_DeleteDirector]
(
	@name VARCHAR(255),
	@birthdate DATE
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			DELETE FROM director
			WHERE name  = @name 
				AND birthdate = @birthdate
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'Unexpected error occured in the procedure "Delete director". Please check your values.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;