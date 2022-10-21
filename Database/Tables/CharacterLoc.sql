CREATE TABLE [dbo].[CharacterLoc]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	IdChar int not null,
	LocU int not null,
	LocS int not null,
	LocP int not null,
	LocA int not null,
	LocA_X int not null,
	LocA_Y int not null
)
