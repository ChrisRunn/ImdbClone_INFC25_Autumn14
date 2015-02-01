USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_GetDirectorByName]    Script Date: 2014-10-31 08:27:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_GetDirectorByName]
(
	@name VARCHAR(255)
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			SELECT * 
			FROM director 
			WHERE name like '%' + @name  + '%'
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'There is no data in the table Director which matches the name.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;
GO

