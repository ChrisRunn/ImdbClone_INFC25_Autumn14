USE [imdbclone]
GO
/****** Object:  Trigger [dbo].[tr_Movie_ForDelete_Audit]    Script Date: 2014-10-31 08:19:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tr_Movie_ForDelete_Audit]
ON [dbo].[Movie]
FOR DELETE
AS
BEGIN
DECLARE @tableName NVARCHAR(255)
DECLARE @userName NVARCHAR(255)
DECLARE @title NVARCHAR(255)
DECLARE @year NVARCHAR(255)

SELECT @tableName = OBJECT_NAME(parent_object_id) FROM sys.objects WHERE sys.objects.name = OBJECT_NAME(@@PROCID)
SELECT @userName = SYSTEM_USER
SELECT @title = title FROM DELETED
SELECT @year = year FROM DELETED

INSERT INTO Audit VALUES (@tableName, @tableName + ' with Title = ' + @title + ' and Year ' + @year + ' was deleted at ' + CONVERT(VARCHAR,GETDATE()), @userName)

END;

