CREATE TABLE [dbo].[CharacterLoc]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	IdChar int not null,
		CONSTRAINT FK_CharacterLoc_IdChar FOREIGN KEY (IdChar)
        REFERENCES Character (Id),
	LocU int not null,
	LocS int not null,
	LocP int not null,
	LocA int not null,
	LocA_X int not null,
	LocA_Y int not null
)
