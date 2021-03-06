USE [imdbclone]
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateMovie]    Script Date: 2014-10-30 09:04:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UpdateMovie]
(
	@title VARCHAR(255),
	@year INT,
	@description NVARCHAR(255),
	@rank INT
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			UPDATE movie
			SET 
				[description] = @description, rank = @rank
				WHERE title = @title AND year = @year
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'Unexpected error occured in the procedure "Update Movie". Please check your values.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;