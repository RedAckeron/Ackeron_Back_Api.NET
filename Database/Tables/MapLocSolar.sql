CREATE TABLE [dbo].[MapLocSolar]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	Name nvarchar(50),
	Owner int,
	CONSTRAINT FK_MapLocSolar_Owner FOREIGN KEY (Owner)
    REFERENCES Character (Id),
	LocU int,
	CONSTRAINT FK_MapLocSolar_IdUnivers FOREIGN KEY (LocU)
    REFERENCES MapLocUnivers (Id),
)
