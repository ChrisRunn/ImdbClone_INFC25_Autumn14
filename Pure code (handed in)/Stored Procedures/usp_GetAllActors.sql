USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_GetAllActors]    Script Date: 2014-10-31 08:25:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_GetAllActors]
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			SELECT * FROM actor
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'There is no data in the table Actor.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;
GO

