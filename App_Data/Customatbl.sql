CREATE TABLE [dbo].[Table]
(
	[CustomaID] INT NOT NULL PRIMARY KEY IDENTITY(201700, 1), 
    [Gender] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NOT NULL, 
    [Fname] VARCHAR(200) NOT NULL, 
    [Lname] VARCHAR(250) NOT NULL, 
    [Bday] DATETIME NULL, 
    [zandoProm] VARCHAR(50) NULL, 
    [zandoBlog] VARCHAR(50) NULL, 
    [zandoDeals] VARCHAR(50) NULL, 
    [password] VARCHAR(50) NOT NULL
)
