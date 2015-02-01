USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_CreateMovie]    Script Date: 2014-10-31 08:22:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_CreateMovie] 
(
	@title VARCHAR(255),
	@year INT,
	@description NVARCHAR(MAX),
	@rank INT
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			INSERT INTO movie (title, year, description, rank) 
				VALUES (@title, @year, @description, @rank)
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'A movie with the title and year you have entered already exists in the database.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END
GO

