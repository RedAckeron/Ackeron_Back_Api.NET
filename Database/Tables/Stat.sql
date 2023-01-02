CREATE TABLE [dbo].[Stat]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	PtMove int DEFAULT 10,
	PtMoveMax int DEFAULT 10,
	xp int DEFAULT 0 NOT NULL,
	Pv int NOT NULL DEFAULT 100,
	PvMax int NOT NULL DEFAULT 100,
	Pw int NOT NULL DEFAULT 100,
	PwMax int NOT NULL DEFAULT 100,
	TimestampSimul int,
	[CoolDown] int DEFAULT 1000 NOT NULL
	)
