USE [imdbclone]
GO
/****** Object:  Trigger [dbo].[tr_Genre_ForDelete_Audit]    Script Date: 2014-10-31 08:19:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tr_Genre_ForDelete_Audit]
ON [dbo].[Genre]
FOR DELETE
AS
BEGIN
DECLARE @tableName NVARCHAR(255)
DECLARE @userName NVARCHAR(255)
DECLARE @name VARCHAR(255)

SELECT @tableName = OBJECT_NAME(parent_object_id) FROM sys.objects WHERE sys.objects.name = OBJECT_NAME(@@PROCID)
SELECT @userName = SYSTEM_USER
SELECT @name = name FROM DELETED

INSERT INTO genreAudit VALUES (@tableName, @tableName + ' with Name = ' + @name + ' was deleted at ' + CONVERT(VARCHAR,GETDATE()), @userName)

END
