USE imdbclone;

CREATE TABLE [dbo].[Actor](
	[name] NVARCHAR(255) NOT NULL,
	[birthdate] DATE NOT NULL,
	[biography] NVARCHAR(MAX) NULL,
	CONSTRAINT [PK_Actor_name_birthdate] PRIMARY KEY (name, birthdate)
 );

 CREATE TABLE [dbo].[Director](
	[name] NVARCHAR(255) NOT NULL,
	[birthdate] DATE NOT NULL,
	[biography] NVARCHAR(255) NULL,
	CONSTRAINT [PK_Director_name_birthdate] PRIMARY KEY(name, birthdate)
 );
 
CREATE TABLE [dbo].[Movie](
	[title] NVARCHAR(255) NOT NULL,
	[year] INT NOT NULL,
	[description] NVARCHAR(MAX) NULL,
	[rank] INT NULL,
	CONSTRAINT [PK_Movie_title_year] PRIMARY KEY(title, year)
 );

CREATE TABLE [dbo].[Genre](
	[name] NVARCHAR(255) NOT NULL,
	CONSTRAINT [PK_Genre_name] PRIMARY KEY(name)
);

 CREATE TABLE [dbo].[Acted](
	[name] NVARCHAR(255) NOT NULL,
	[birthdate] DATE NOT NULL,
	[title] NVARCHAR(255) NOT NULL,
	[year] INT NOT NULL,
	CONSTRAINT [PK_Acted_name_birthdate_title_year] PRIMARY KEY (name, birthdate, title, year),
	CONSTRAINT [FK_Acted_name_birthdate__Actor_name_birthdate] 
		FOREIGN KEY(name, birthdate) REFERENCES Actor(name, birthdate) 
			ON DELETE CASCADE 
			ON UPDATE CASCADE,
	CONSTRAINT [FK_Acted_title_year__Movie_title_year] 
		FOREIGN KEY(title, year) REFERENCES Movie(title, year) 
			ON DELETE CASCADE 
			ON UPDATE CASCADE
);

CREATE TABLE [dbo].[MovieGenre](
	[genre] NVARCHAR(255) NOT NULL,
	[title] NVARCHAR(255) NOT NULL,
	[year] INT NOT NULL,
	CONSTRAINT [PK_MovieGenre_genre_title_year] PRIMARY KEY(genre, title, year),
	CONSTRAINT [FK_MovieGenre_genre__Genre_name] 
		FOREIGN KEY(genre) REFERENCES Genre(name)
			ON DELETE CASCADE 
			ON UPDATE CASCADE,
	CONSTRAINT [FK_MovieGenre_title_year__Movie_title_year] 
		FOREIGN KEY(title, year) REFERENCES Movie(title, year)
			ON DELETE CASCADE 
			ON UPDATE CASCADE
 );

  CREATE TABLE [dbo].[Directed](
	[name] NVARCHAR(255) NOT NULL,
	[birthdate] DATE NOT NULL,
	[title] NVARCHAR(255) NOT NULL,
	[year] INT NOT NULL,
	CONSTRAINT [PK_Directed_name_birthdate_title_year] PRIMARY KEY (name, birthdate, title, year),
	CONSTRAINT [FK_Directed_name_birhtdate__Director_name_birthdate] 
		FOREIGN KEY(name, birthdate) REFERENCES Director(name, birthdate)
			ON DELETE CASCADE 
			ON UPDATE CASCADE,
	CONSTRAINT [FK_Directed_title_year__Movie_title_year] 
		FOREIGN KEY(title, year) REFERENCES Movie(title, year)
			ON DELETE CASCADE 
			ON UPDATE CASCADE
 );
 
 CREATE TABLE [dbo].[Audit](
	[id] INT IDENTITY(1,1) NOT NULL,
	[tableName] NVARCHAR(255) NOT NULL,
	[auditData] NVARCHAR(MAX) NULL,
	[userName] NVARCHAR(255) NOT NULL,
	CONSTRAINT [PK_AuditData_id] PRIMARY KEY(id)
);