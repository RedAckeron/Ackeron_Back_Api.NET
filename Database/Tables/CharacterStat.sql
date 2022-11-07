CREATE TABLE [dbo].[CharacterStat]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	IdChar int not null,
		CONSTRAINT FK_CharacterStat_IdChar FOREIGN KEY (IdChar)
        REFERENCES Character (Id),
	TimestampSimul int,
	PtMove int,
	PtMoveMax int,
	xp int,
	Pv int,
	PvMax int,
	Pw int,
	PwMax int,
	Gold int
	)
