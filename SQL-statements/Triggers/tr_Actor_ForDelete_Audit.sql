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