CREATE TABLE [dbo].[CharacterStat]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	IdChar int not null,
	TimestampSimul int,
	PtMove int,
	PtMoveMax int,
	xp int,
	Pv int,
	PvMax int,
	Pe int,
	PeMax int,
	Gold int
	)
