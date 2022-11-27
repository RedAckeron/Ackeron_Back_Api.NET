CREATE TABLE [dbo].[MapLocUnivers]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	name nvarchar(50),
	Owner int,
	CONSTRAINT FK_MapLocUnivers_Owner FOREIGN KEY (Owner)
    REFERENCES Character (Id),
)
