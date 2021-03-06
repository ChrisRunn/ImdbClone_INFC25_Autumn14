USE [imdbclone]
GO
/****** Object:  Trigger [dbo].[tr_Movie_ForInsert_Audit]    Script Date: 2014-10-31 08:19:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tr_Movie_ForInsert_Audit]
ON [dbo].[Movie]
FOR INSERT
AS
BEGIN
	DECLARE @userName NVARCHAR(255)
	DECLARE @tableName NVARCHAR(255)
	DECLARE @title VARCHAR(255)
	DECLARE @year INT
	
	SELECT @tableName = OBJECT_NAME(parent_object_id) FROM sys.objects WHERE sys.objects.name = OBJECT_NAME(@@PROCID)
	SELECT @userName = SYSTEM_USER
	SELECT @title = title FROM inserted
	SELECT @year = year FROM inserted

	INSERT INTO Audit VALUES (@tableName, 'New ' + LOWER(@tableName) + ' with Title = ' + @title +
							 ' and Year = ' + CONVERT(NVARCHAR,@year) + ' was added at ' + CONVERT(NVARCHAR,GETDATE()),
							 @userName)

END
