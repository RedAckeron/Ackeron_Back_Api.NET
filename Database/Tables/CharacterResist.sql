CREATE TABLE [dbo].[CharacterResist]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	[IdChar] int,
		CONSTRAINT FK_CharacterResist_IdChar FOREIGN KEY (IdChar)
        REFERENCES Character (Id),
	[eau] int,
	[feu] int,
	[air] int,
	[terre] int,
	[lumiere] int,
	[tenebre] int,
	[tranchant] int,
	[ecrasant] int,
	[percant] int,
	[poison] int
)
