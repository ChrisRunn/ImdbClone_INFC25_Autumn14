USE [imdbclone]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetDirectedByNameOrTitle]    Script Date: 2014-10-30 08:57:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GetDirectedByNameOrTitle]
(
	@searchString VARCHAR(255)
)
AS
	DECLARE @customizedErrorMessage NVARCHAR(255)
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			SELECT * 
			FROM directed 
			WHERE name like '%' + @searchString  + '%' or title like '%' + @searchString  + '%'
		END TRY
		
		BEGIN CATCH
			SET @customizedErrorMessage = 'There is no data in the table Directed.'
			EXEC usp_ErrorHandling @customizedErrorMessage
		END CATCH
	COMMIT
END;