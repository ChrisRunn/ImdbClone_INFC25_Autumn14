CREATE TRIGGER [dbo].[tr_Actor_ForDelete_Audit]
ON [dbo].[Actor]
FOR DELETE
AS
BEGIN
DECLARE @tableName NVARCHAR(255)
DECLARE @userName NVARCHAR(255)
DECLARE @name VARCHAR(255)
DECLARE @birthdate DATE

SELECT @userName = SYSTEM_USER
SELECT @birthdate = birthdate FROM DELETED
SELECT @name = name FROM DELETED
SELECT @tableName = OBJECT_NAME(parent_object_id) FROM sys.objects WHERE sys.objects.name = OBJECT_NAME(@@PROCID)

INSERT INTO Audit VALUES (@tableName, 'Actor with Name = ' + @name + ' and Birthdate = ' + CONVERT(NVARCHAR,@birthdate) + ' was deleted at ' + CONVERT(VARCHAR,GETDATE()), @userName)

END;

DROP TRIGGER [dbo].[tr_Actor_ForInsert_Audit]
CREATE TRIGGER [dbo].[tr_Actor_ForInsert_Audit]
ON [dbo].[Actor]
FOR INSERT
AS
BEGIN
	DECLARE @userName NVARCHAR(255)
	DECLARE @tableName NVARCHAR(255)
	DECLARE @name VARCHAR(255)
	DECLARE @birthdate DATE

	SELECT @userName = SYSTEM_USER
	SELECT @name = name FROM inserted
	SELECT @birthdate = birthdate FROM inserted
	SELECT @tableName = OBJECT_NAME(parent_object_id) FROM sys.objects WHERE sys.objects.name = OBJECT_NAME(@@PROCID)

	INSERT INTO Audit VALUES (@tableName, 'New ' + LOWER(@tableName) + ' with Name = ' + @name +
							 ' and Birthdate = ' + CONVERT(NVARCHAR,@birthdate) + ' was added at ' + CONVERT(NVARCHAR,GETDATE()), @userName)

END;

DROP TRIGGER [dbo].[tr_Director_ForDelete_Audit]
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

DROP TRIGGER [dbo].[tr_Director_ForInsert_Audit]
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


DROP TRIGGER [dbo].[tr_Genre_ForDelete_Audit]
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

END;

DROP TRIGGER [dbo].[tr_Genre_ForInsert_Audit]
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

DROP TRIGGER [dbo].[tr_Movie_ForDelete_Audit]
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

DROP TRIGGER [dbo].[tr_Movie_ForDelete_Audit]
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








