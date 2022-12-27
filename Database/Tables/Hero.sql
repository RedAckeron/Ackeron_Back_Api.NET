CREATE TABLE [dbo].[Hero]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
 	TsIn int,
	LocalisatorId int,
		CONSTRAINT FK_Character_LocalisatorId FOREIGN KEY (LocalisatorId) REFERENCES Localisator (Id),
	InfoId int,
		CONSTRAINT FK_Hero_InfoId FOREIGN KEY (InfoId) REFERENCES Info (Id),
	StatId int,
		CONSTRAINT FK_Hero_StatId FOREIGN KEY (StatId) REFERENCES Stat (Id),
	PowerId int,
		CONSTRAINT FK_Hero_PowerId FOREIGN KEY (PowerId) REFERENCES [Power] (Id),
	ResistId int,
		CONSTRAINT FK_Hero_resistId FOREIGN KEY (ResistId) REFERENCES Resist (Id),

	
)