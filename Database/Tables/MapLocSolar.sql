CREATE TABLE [dbo].[MapLocSolar]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	Name nvarchar(50),
	Owner int,
	
	LocU int,
	CONSTRAINT FK_MapLocSolar_IdUnivers FOREIGN KEY (LocU)
    REFERENCES MapLocUnivers (Id),
)
