USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_GetActorByName]    Script Date: 2014-10-31 08:25:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_GetActorByName]
(
	@name VARCHAR(255)
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			SELECT * FROM actor where name like '%' + @name  + '%'
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'There is no data in the table Actor.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;
GO

