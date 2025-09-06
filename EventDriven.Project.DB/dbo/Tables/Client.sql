CREATE TABLE [dbo].[Client]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	[Firstname] varchar(30) NULL,
	[Lastname] varchar(30) NULL,
	[MobileNumber] nvarchar(30) NULL,
	[Gender] varchar(30) NULL,
	[Address] varchar(50) NULL,
	[Birthdate] DateTime NULL,
)
