CREATE TABLE [dbo].[Character]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	[Name] varchar(100),
	Race int,
	Sexe int,
	Classe int,
	LocalisatorId int,
		CONSTRAINT FK_Character_LocalisatorId FOREIGN KEY (LocalisatorId) REFERENCES Localisator (Id),

	PowerId int,
		CONSTRAINT FK_Character_PowerId FOREIGN KEY (PowerId) REFERENCES [Power] (Id),

	ResistId int,
		CONSTRAINT FK_Character_resistId FOREIGN KEY (ResistId) REFERENCES Resist (Id),
	CitizenPlanet int,
 	TsIn int
)