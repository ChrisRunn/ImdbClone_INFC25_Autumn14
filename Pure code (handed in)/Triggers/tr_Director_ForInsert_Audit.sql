USE [imdbclone]
GO
/****** Object:  Trigger [dbo].[tr_Director_ForInsert_Audit]    Script Date: 2014-10-31 08:18:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tr_Director_ForInsert_Audit]
ON [dbo].[Director]
FOR INSERT
AS
BEGIN
	DECLARE @userName NVARCHAR(255)
	DECLARE @tableName NVARCHAR(255)
	DECLARE @name VARCHAR(255)
	DECLARE @birthdate DATE

	SELECT @tableName = OBJECT_NAME(parent_object_id) FROM sys.objects WHERE sys.objects.name = OBJECT_NAME(@@PROCID)
	SELECT @userName = SYSTEM_USER
	SELECT @name = name FROM inserted
	SELECT @birthdate = birthdate FROM inserted

	INSERT INTO Audit VALUES (@tableName, 'New ' + LOWER(@tableName) + ' with Name = ' + @name +
							 ' and Birthdate = ' + CONVERT(NVARCHAR,@birthdate) + ' was added at ' + CONVERT(NVARCHAR,GETDATE()), @userName)

END;


