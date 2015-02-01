USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_CreateActed]    Script Date: 2014-10-31 08:21:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_CreateActed]
(
	@name VARCHAR(255),
	@birthdate DATE,
	@title VARCHAR(255),
	@year INT
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			INSERT INTO acted(name, birthdate, title, year) 
				VALUES(@name, @birthdate, @title, @year)
		END TRY
		BEGIN CATCH
		SET @customizedErrorMessage = 'The movie already contains this actor'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;
GO

