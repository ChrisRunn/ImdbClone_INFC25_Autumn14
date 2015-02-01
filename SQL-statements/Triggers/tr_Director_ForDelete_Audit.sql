CREATE TRIGGER tr_Director_ForDelete_Audit
ON Director
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

END
