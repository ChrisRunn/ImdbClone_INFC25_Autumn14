USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_UpdateMovie]    Script Date: 2014-10-31 08:30:22 ******/
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
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			UPDATE movie
			SET 
				[description] = @description, rank = @rank
				WHERE title = @title AND year = @year
		END TRY
		BEGIN CATCH
			EXEC usp_ErrorHandling
		END CATCH
	COMMIT
END;
GO

