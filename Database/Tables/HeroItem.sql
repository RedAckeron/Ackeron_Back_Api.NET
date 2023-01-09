CREATE TABLE [dbo].[HeroItem]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	IdChar int ,
		CONSTRAINT FK_CharacterItem_IdCharacter FOREIGN KEY (IdChar)
        REFERENCES Hero (Id),
	IdItem int,
		CONSTRAINT FK_CharacterItem_IdItem FOREIGN KEY (IdItem)
        REFERENCES Item (Id),
	Qt int,
	

)
