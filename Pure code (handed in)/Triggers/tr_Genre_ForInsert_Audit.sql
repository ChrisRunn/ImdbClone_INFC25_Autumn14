USE [imdbclone]
GO
/****** Object:  Trigger [dbo].[tr_Genre_ForInsert_Audit]    Script Date: 2014-10-31 08:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tr_Genre_ForInsert_Audit]
ON [dbo].[Genre]
FOR INSERT
AS
BEGIN 
	DECLARE @userName NVARCHAR(255)
	DECLARE @userRole NVARCHAR(255)
	DECLARE @tableName NVARCHAR(255)
	DECLARE @name VARCHAR(255)

	SELECT @userName = SYSTEM_USER
	
	SELECT @tableName = OBJECT_NAME(parent_object_id) FROM sys.objects WHERE sys.objects.name = OBJECT_NAME(@@PROCID)

	SELECT @name = name FROM inserted

	INSERT INTO Audit VALUES (@tableName, 'New ' + LOWER(@tableName) + ' with Name = ' + @name + ' was added at ' + CONVERT(NVARCHAR,GETDATE()),
								@userName)

END;

