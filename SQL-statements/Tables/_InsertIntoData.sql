USE imdbclone;

INSERT INTO Actor(name, birthdate, biography) VALUES('Bryan Cranston', '1956-03-07', 
'Bryan Lee Cranston is an American actor, voice actor, writer and director. He is perhaps best-known for his roles as "Walter White" on the AMC drama series, Breaking Bad (2008), 
for which he has won four consecutive Outstanding Lead Actor in a Drama Series Emmy Awards, and as "Hal", the father on the Fox situation comedy, Malcolm - ett geni i familjen (2000).');

INSERT INTO Actor(name, birthdate, biography) VALUES('Emma Watson', '1990-04-15', NULL);
INSERT INTO Actor(name, birthdate, biography) VALUES('Emily Blunt', '1983-02-23', NULL);
INSERT INTO Actor(name, birthdate, biography) VALUES('Jason Segel', '1980-01-18', NULL);
INSERT INTO Actor(name, birthdate, biography) VALUES('Tom Cruise', '1962-07-03', NULL);
INSERT INTO Actor(name, birthdate, biography) VALUES('Bruce Willis', '1955-03-19', NULL);
INSERT INTO Actor(name, birthdate, biography) VALUES('Joseph Gordon-Levitt', '1981-02-17', NULL);
INSERT INTO Actor(name, birthdate, biography) VALUES('Sigourney Weaver', '1949-10-08', NULL);


INSERT INTO Movie(title, year, description, rank) VALUES('Godzilla', 2014, 
	'The world큦 most famous monster is pitted against malevolent creatures who, bolstered by humanity큦 scientific arrogance, threaten our very existence.', NULL);
INSERT INTO Movie(title, year, description, rank) VALUES('The Perks of Being a Wallflower', 2012, 
	'An introvert freshman is taken under the wings of two seniors who welcome him to the real world.', NULL);
INSERT INTO Movie(title, year, description, rank) VALUES('Argo', 2012, 
	'Acting under the cover of a Hollywood producer scouting a location for a science fiction film, a CIA agent launches a dangerous operation to rescue six Americans in Tehran during the U.S. hostage crisis in Iran in 1980.', NULL);
INSERT INTO Movie(title, year, description, rank) VALUES('Edge of Tomorrow', 2014, 
	'An officer finds himself caught in a time loop in a war with the alien race. His skills increase as he faces the same brutal combat scenarios, and his union with a Special Forces warrior gets him closer to defeating the enemy.', NULL);
INSERT INTO Movie(title, year, description, rank) VALUES('Looper', 2012, 
	'In 2074, when the mob wants to get rid of someone, the target is sent into the past, where a hired gun awaits - someone like Joe - who one day learns the mob wants to "close the loop" by sending back Joe큦 future self for assassination.', NULL);
INSERT INTO Movie(title, year, description, rank) VALUES('The Five-Year Engagement', 2012, 
	'One year after meeting, Tom proposes to his girlfriend, Violet, but unexpected events keep tripping them up as they look to walk down the aisle together.', NULL);
INSERT INTO Movie(title, year, description, rank) VALUES('Die Hard', 1988, 
	'John McClane, officer of the NYPD, tries to save wife Holly Gennaro and several others, taken hostage by German terrorist Hans Gruber during a Christmas party at the Nakatomi Plaza in Los Angeles.', NULL);
INSERT INTO Movie(title, year, description, rank) VALUES('The Lord of the Rings: The Fellowship of the Ring', 2001, 
	'A meek hobbit of the Shire and eight companions set out on a journey to Mount Doom to destroy the One Ring and the dark lord Sauron.', NULL);
INSERT INTO Movie(title, year, description, rank) VALUES('The Lord of the Rings: The Two Towers', 2002, 
	'While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron큦 new ally, Saruman, and his hordes of Isengard.', NULL);
INSERT INTO Movie(title, year, description, rank) VALUES('The Lord of the Rings: The Return of the King', 2003, 
	'Gandalf and Aragorn lead the World of Men against Sauron큦 army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.', NULL);


INSERT INTO Director(name, birthdate, biography) VALUES ('Nicholas Stoller', '1976-03-19', NULL);
INSERT INTO Director(name, birthdate, biography) VALUES ('Peter Jackson', '1961-10-31', NULL);
INSERT INTO Director(name, birthdate, biography) VALUES ('Rian Johnson', '1973-12-17', NULL);
INSERT INTO Director(name, birthdate, biography) VALUES ('Steven Spielberg', '1946-12-18', NULL);
INSERT INTO Director(name, birthdate, biography) VALUES ('Martin Scorsese', '1942-11-17', NULL);
INSERT INTO Director(name, birthdate, biography) VALUES ('Quentin Tarantino', '1963-03-27', NULL);

INSERT INTO Genre(name) VALUES('Action');
INSERT INTO Genre(name) VALUES('Drama');
INSERT INTO Genre(name) VALUES('Romance');
INSERT INTO Genre(name) VALUES('Comedy');
INSERT INTO Genre(name) VALUES('Thriller');
INSERT INTO Genre(name) VALUES('Sci-Fi');
INSERT INTO Genre(name) VALUES('Crime');
INSERT INTO Genre(name) VALUES('Adventure');
INSERT INTO Genre(name) VALUES('Fantasy');

INSERT INTO Acted(name, birthdate, title, year) VALUES('Bryan Cranston', '1956-03-07', 'Argo', 2012);
INSERT INTO Acted(name, birthdate, title, year) VALUES('Emma Watson', '1990-04-15', 'The Perks of Being a Wallflower', 2012);
INSERT INTO Acted(name, birthdate, title, year) VALUES('Emily Blunt', '1983-02-23', 'The Five-Year Engagement', 2012);
INSERT INTO Acted(name, birthdate, title, year) VALUES('Emily Blunt', '1983-02-23', 'Edge of Tomorrow', 2014);
INSERT INTO Acted(name, birthdate, title, year) VALUES('Emily Blunt', '1983-02-23', 'Looper', 2012);
INSERT INTO Acted(name, birthdate, title, year) VALUES('Jason Segel', '1980-01-18', 'The Five-Year Engagement', 2012);
INSERT INTO Acted(name, birthdate, title, year) VALUES('Tom Cruise', '1962-07-03', 'Edge of Tomorrow', 2014);
INSERT INTO Acted(name, birthdate, title, year) VALUES('Bruce Willis', '1955-03-19', 'Die Hard', 1988);
INSERT INTO Acted(name, birthdate, title, year) VALUES('Bruce Willis', '1955-03-19', 'Looper', 2012);
INSERT INTO Acted(name, birthdate, title, year) VALUES('Joseph Gordon-Levitt', '1981-02-17', 'Looper', 2012);

INSERT INTO Directed(name, birthdate, title, year) VALUES('Nicholas Stoller', '1976-03-19', 'The Five-Year Engagement', 2012);
INSERT INTO Directed(name, birthdate, title, year) VALUES('Rian Johnson', '1973-12-17', 'Looper', 2012);
INSERT INTO Directed(name, birthdate, title, year) VALUES('Peter Jackson', '1961-10-31', 'The Lord of the Rings: The Fellowship of the Ring', 2001);
INSERT INTO Directed(name, birthdate, title, year) VALUES('Peter Jackson', '1961-10-31', 'The Lord of the Rings: The Two Towers', 2002);
INSERT INTO Directed(name, birthdate, title, year) VALUES('Peter Jackson', '1961-10-31', 'The Lord of the Rings: The Return of the King', 2003);

INSERT INTO MovieGenre(genre, title, year) VALUES('Action', 'Godzilla', 2014);
INSERT INTO MovieGenre(genre, title, year) VALUES('Sci-Fi', 'Godzilla', 2014);
INSERT INTO MovieGenre(genre, title, year) VALUES('Thriller', 'Godzilla', 2014);
INSERT INTO MovieGenre(genre, title, year) VALUES('Drama', 'The Perks of Being a Wallflower', 2012);
INSERT INTO MovieGenre(genre, title, year) VALUES('Romance', 'The Perks of Being a Wallflower', 2012);
INSERT INTO MovieGenre(genre, title, year) VALUES('Drama', 'Argo', 2012);
INSERT INTO MovieGenre(genre, title, year) VALUES('Thriller', 'Argo', 2012);
INSERT INTO MovieGenre(genre, title, year) VALUES('Action', 'Edge of Tomorrow', 2014);
INSERT INTO MovieGenre(genre, title, year) VALUES('Sci-Fi', 'Edge of Tomorrow', 2014);
INSERT INTO MovieGenre(genre, title, year) VALUES('Action', 'Looper', 2012);
INSERT INTO MovieGenre(genre, title, year) VALUES('Crime', 'Looper', 2012);
INSERT INTO MovieGenre(genre, title, year) VALUES('Sci-Fi', 'Looper', 2012);
INSERT INTO MovieGenre(genre, title, year) VALUES('Comedy', 'The Five-Year Engagement', 2012);
INSERT INTO MovieGenre(genre, title, year) VALUES('Romance', 'The Five-Year Engagement', 2012);
INSERT INTO MovieGenre(genre, title, year) VALUES('Action', 'Die Hard', 1988);
INSERT INTO MovieGenre(genre, title, year) VALUES('Thriller', 'Die Hard', 1988);
INSERT INTO MovieGenre(genre, title, year) VALUES('Fantasy', 'The Lord of the Rings: The Fellowship of the Ring', 2001);
INSERT INTO MovieGenre(genre, title, year) VALUES('Adventure', 'The Lord of the Rings: The Fellowship of the Ring', 2001);
INSERT INTO MovieGenre(genre, title, year) VALUES('Action', 'The Lord of the Rings: The Fellowship of the Ring', 2001);

INSERT INTO MovieGenre(genre, title, year) VALUES('Fantasy', 'The Lord of the Rings: The Two Towers', 2002);
INSERT INTO MovieGenre(genre, title, year) VALUES('Adventure', 'The Lord of the Rings: The Two Towers', 2002);
INSERT INTO MovieGenre(genre, title, year) VALUES('Action', 'The Lord of the Rings: The Two Towers', 2002);

INSERT INTO MovieGenre(genre, title, year) VALUES('Fantasy', 'The Lord of the Rings: The Return of the King', 2003);
INSERT INTO MovieGenre(genre, title, year) VALUES('Adventure', 'The Lord of the Rings: The Return of the King', 2003);
INSERT INTO MovieGenre(genre, title, year) VALUES('Action', 'The Lord of the Rings: The Return of the King', 2003);




