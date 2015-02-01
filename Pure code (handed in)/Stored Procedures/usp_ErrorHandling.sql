USE [imdbclone]
GO

/****** Object:  StoredProcedure [dbo].[usp_ErrorHandling]    Script Date: 2014-10-31 08:24:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_ErrorHandling] 
(
	@customizedErrorMessage NVARCHAR(255)
)
AS
	DECLARE @errorseverity INT;
	DECLARE @errorstate INT;
BEGIN

	

	
	SET @errorseverity = ERROR_SEVERITY();
	SET @errorstate = ERROR_STATE();
	

	RAISERROR (@customizedErrorMessage, @errorseverity, @errorstate);
END

GO

