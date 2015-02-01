USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_CreateDirected]    Script Date: 2014-10-31 08:21:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_CreateDirected]
(
	@name NVARCHAR(255),
	@birthdate DATE, 
	@title VARCHAR(255),
	@year INT
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			INSERT INTO directed (name, birthdate, title, year)
			VALUES (@name, @birthdate, @title, @year);
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'The movie already contains this director.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;

GO

