USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_GetAllMoviesForDirector]    Script Date: 2014-10-31 08:27:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_GetAllMoviesForDirector]
(
	@name VARCHAR(255), -- Director name
	@birthdate DATE  -- Director birthdate
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			SELECT m.title, m.[year], m.[description], m.[rank]
			FROM Movie m
			INNER JOIN Directed d
			ON m.[title] = d.title
			AND m.[year] = d.[year]
			WHERE name = @name 
				AND birthdate = @birthdate
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'There are no movies which matches the director.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;
GO

