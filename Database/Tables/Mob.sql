CREATE TABLE [dbo].[Mob]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	
	[MobGabaritId] int,
 	TsIn int,

	LocalisatorId int,
		CONSTRAINT FK_Mob_LocalisatorId FOREIGN KEY (LocalisatorId) REFERENCES Localisator (Id),
	InfoId int,
		CONSTRAINT FK_Mob_InfoId FOREIGN KEY (InfoId) REFERENCES Info (Id),
	StatId int,
		CONSTRAINT FK_Mob_StatId FOREIGN KEY (StatId) REFERENCES Stat (Id),
	PowerId int,
		CONSTRAINT FK_Mob_PowerId FOREIGN KEY (PowerId) REFERENCES [Power] (Id),
	ResistId int,
		CONSTRAINT FK_Mob_resistId FOREIGN KEY (ResistId) REFERENCES Resist (Id),

	
)