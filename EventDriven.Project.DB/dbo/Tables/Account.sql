CREATE TABLE [dbo].[Account]
(
	Id INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    ClientId INT NOT NULL,
    Balance DECIMAL(15, 2) DEFAULT 0.00,
    ModifiedDate DateTime,
    FOREIGN KEY (ClientId) REFERENCES Client(Id)
);

