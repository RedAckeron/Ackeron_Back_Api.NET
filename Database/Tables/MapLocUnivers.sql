CREATE TABLE [dbo].[MapLocUnivers]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	LocalisatorId int,
	CONSTRAINT FK_MapLocUnivers_Localisator FOREIGN KEY (LocalisatorId) REFERENCES Localisator (Id),
	name nvarchar(50),
	Owner int,
)
