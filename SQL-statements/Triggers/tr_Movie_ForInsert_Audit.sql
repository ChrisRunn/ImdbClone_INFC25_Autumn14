CREATE TRIGGER tr_Movie_ForInsert_Audit
ON Movie
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
