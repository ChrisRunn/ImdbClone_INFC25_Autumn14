USE [imdbclone]
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateActor]    Script Date: 2014-10-30 09:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UpdateActor]
(
	@name VARCHAR(255),
	@birthdate DATE,
	@biography NVARCHAR(MAX)
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			UPDATE actor
			SET biography = @biography
			WHERE name  = name AND birthdate = @birthdate
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'Unexpected error occured in the procedure "Update Actor". Please check your values.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;