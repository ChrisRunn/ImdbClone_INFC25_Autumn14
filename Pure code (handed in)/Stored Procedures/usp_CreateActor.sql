USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_CreateActor]    Script Date: 2014-10-31 08:21:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_CreateActor] 
(
	@name NVARCHAR(255),
	@birthdate DATE,
	@biography NVARCHAR(MAX)
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			INSERT INTO actor(name, birthdate, biography)
				VALUES(@name, @birthdate, @biography)
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'An actor with the name and birthdate you have entered already exists in the database.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END

GO

