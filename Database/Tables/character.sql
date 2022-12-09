CREATE TABLE [dbo].[Character]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	[Name] varchar(100),
	Race int,
	Sexe int,
	Classe int,
	LocalisatorId int,
	CONSTRAINT FK_Character_LocalisatorId FOREIGN KEY (LocalisatorId)
    REFERENCES Localisator (Id),
	CitizenPlanet int,
 	TsIn int
)