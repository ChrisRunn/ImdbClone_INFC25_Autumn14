USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_GetAuditData]    Script Date: 2014-10-31 08:27:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_GetAuditData]
AS
BEGIN
	BEGIN TRY
		SELECT *
		FROM Audit
	END TRY

	BEGIN CATCH
		EXEC usp_ErrorHandling 'Unexpected error when trying to fetch Audit data'
	END CATCH
END
GO

