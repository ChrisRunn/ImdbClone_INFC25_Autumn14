USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_GetAllMoviesForActor]    Script Date: 2014-10-31 08:26:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_GetAllMoviesForActor]
(
	@name VARCHAR(255), --Actor name
	@birthdate DATE --Actor birthdate
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY

			SELECT m.title, m.[year], m.[description], m.[rank]
			FROM Movie m
			INNER JOIN Acted a
			ON m.title = a.title
			AND m.[year] = a.[year]
			WHERE name = @name 
				AND birthdate = @birthdate
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'There are no movies which matches the actor.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;

GO

