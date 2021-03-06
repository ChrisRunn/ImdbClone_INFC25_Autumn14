USE [imdbclone]
GO
/****** Object:  Trigger [dbo].[tr_Director_ForDelete_Audit]    Script Date: 2014-10-31 08:18:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tr_Director_ForDelete_Audit]
ON [dbo].[Director]
FOR DELETE
AS
BEGIN
	DECLARE @tableName NVARCHAR(255)
	DECLARE @userName NVARCHAR(255)
	DECLARE @name VARCHAR(255)
	DECLARE @birthdate DATE

	SELECT @tableName = OBJECT_NAME(parent_object_id) FROM sys.objects WHERE sys.objects.name = OBJECT_NAME(@@PROCID)
	SELECT @userName = SYSTEM_USER
	SELECT @name = name FROM DELETED
	SELECT @birthdate = birthdate FROM DELETED

	INSERT INTO Audit VALUES (@tableName, @tableName + ' with Name = ' + @name +' and Birthdate = ' + CONVERT(NVARCHAR,@birthdate) + ' was deleted at ' + CONVERT(VARCHAR,GETDATE()), @userName)

END;

