CREATE TABLE [dbo].[CharacterSpell]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	IdChar int ,
		CONSTRAINT FK_CharacterSpell_IdCharacter FOREIGN KEY (IdChar)
        REFERENCES Hero (Id),
	IdSpell int,
		CONSTRAINT FK_CharacterSpell_IdSpell FOREIGN KEY (IdSpell)
        REFERENCES Spell (Id),
)
