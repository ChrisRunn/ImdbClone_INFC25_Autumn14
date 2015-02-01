USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_GetAllActorsForMovie]    Script Date: 2014-10-31 08:25:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_GetAllActorsForMovie]
(
	@title NVARCHAR(255),
	@year INT	
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			SELECT a.name, a.birthdate, a.biography
			FROM Actor a
			INNER JOIN Acted ac
			ON a.name = ac.name
				AND a.birthdate = ac.birthdate
			WHERE ac.title = @title
				AND ac.[year] = @year
		END TRY
		BEGIN CATCH
			SET @customizedErrorMessage = 'There is no data in the table Acted.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END
GO

