USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_UpdateActor]    Script Date: 2014-10-31 08:29:44 ******/
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
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			UPDATE actor
			SET biography = @biography
			WHERE name  = name AND birthdate = @birthdate
		END TRY
		BEGIN CATCH
			EXEC usp_ErrorHandling
		END CATCH
	COMMIT
END;
GO

