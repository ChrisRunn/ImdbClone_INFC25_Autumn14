USE [imdbclone]
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateDirector]    Script Date: 2014-10-30 09:03:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UpdateDirector]
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
			UPDATE director
			SET biography = @biography
			WHERE name  = @name AND birthdate = @birthdate
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'Unexpected error occured in the procedure "Update Director". Please check your values.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;
