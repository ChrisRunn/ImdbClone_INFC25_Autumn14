USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_UpdateGenre]    Script Date: 2014-10-31 08:30:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_UpdateGenre] 
(
	@name VARCHAR(255),
	@oldName VARCHAR(255)
)
AS

BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			UPDATE genre
			SET name = @name
			WHERE name = @oldName
		END TRY
		BEGIN CATCH
			EXEC usp_ErrorHandling
		END CATCH
	COMMIT
END;
GO

