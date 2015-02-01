USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_CreateMovieGenre]    Script Date: 2014-10-31 08:22:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_CreateMovieGenre]
(
	@genre VARCHAR(255),
	@title VARCHAR(255),
	@year INT
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			INSERT INTO moviegenre(genre, title, year) 
				VALUES(@genre, @title, @year)
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'The movie already has this genre'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;
GO


