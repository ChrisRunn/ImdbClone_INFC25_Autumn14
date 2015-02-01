USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_UpdateDirector]    Script Date: 2014-10-31 08:29:56 ******/
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
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			UPDATE director
			SET biography = @biography
			WHERE name  = @name AND birthdate = @birthdate
		END TRY
		BEGIN CATCH
			EXEC usp_ErrorHandling
		END CATCH
	COMMIT
END;

GO

