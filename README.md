## Synopsis

A Windows desktop application written in C# and TSQL.

There are several folders to this project.
ImdbClone_project is the actual C# application, which consists of 
a GUI, a controller class, a data access class. The data access is done with
Entity Framework, which also generated our entity model from the database.
The data access class simply called on the stored procedures in the database.

All the SQL-statements we wrote is included. There are create table statements and  
statements for adding test data so it is possible to recreate the database.
In the future I might add the database as a part of the Visual Studio solution.

Furthermore, all the stored procedures we used for CRUD and all triggers we used for
our pretty simplistic Audit-table are included.

## Motivation

The project was done as a part of the course Advanced Database Systems 
(INFC25) at Lund University, during the month of October 2014.

Expressed in a simplistic way, the requirements was to use Stored Procedures
for CRUD, have customized error handling on the server/database-side and use triggers
in some way. It was recommended to use a GUI from an earlier project/application 
(due to time limits) so that's what we did. We did, however, replace
the earlier data access layer and entity model to fit the requirements.

## Installation

TODO  
Provide code examples and explanations of how to get the project.

## TODO
Include database in the solution, so that the application actually
is usable without re-creating the database and changing the connection string.

## Contributors
 
Daniel Lindén - [LinkedIn](https://se.linkedin.com/in/daniellinden22)  
Sebastian Glad -  
Christian Runnström - [LinkedIn](https://se.linkedin.com/pub/christian-runnström/a4/606/592)  
Anton Hollerup - [LinkedIn](https://se.linkedin.com/pub/anton-hollerup/93/b5b/14a)  

