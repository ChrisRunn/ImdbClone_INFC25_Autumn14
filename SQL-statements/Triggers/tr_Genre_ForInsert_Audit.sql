CREATE TRIGGER tr_Genre_ForInsert_Audit
ON Genre
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


END
