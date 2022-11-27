CREATE TABLE [dbo].[MapLocArea]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	name nvarchar(50),
	Owner int,
	CONSTRAINT FK_MapLocPArea_Owner FOREIGN KEY (Owner)
    REFERENCES Character (Id),
	LocU int,
	CONSTRAINT FK_MapLocArea_IdUnivers FOREIGN KEY (LocU)
    REFERENCES MapLocUnivers (Id),
	LocS int,
	CONSTRAINT FK_MapLocArea_IdSolar FOREIGN KEY (LocS)
    REFERENCES MapLocSolar (Id),
	LocP int,
	CONSTRAINT FK_MapLocArea_IdPlanet FOREIGN KEY (LocP)
    REFERENCES MapLocPlanet (Id),
	LocX int,
	LocY int,
	MainTrigger nvarchar(50),
	SubTrigger nvarchar(50),
	ImgItem nvarchar(50),
	Reachable bit,
	Lvl int,
	Refresh int
)
