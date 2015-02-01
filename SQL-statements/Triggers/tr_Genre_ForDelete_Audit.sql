ALTER TRIGGER tr_Genre_ForDelete_Audit
ON genre
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
