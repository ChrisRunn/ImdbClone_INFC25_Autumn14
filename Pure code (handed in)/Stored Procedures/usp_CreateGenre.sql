USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_CreateGenre]    Script Date: 2014-10-31 08:22:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_CreateGenre] 
(
	@name NVARCHAR(255)
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			INSERT INTO genre(name)
				VALUES(@name)
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'The genre you have entered already exists in the database.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;
GO

