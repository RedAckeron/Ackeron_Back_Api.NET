CREATE TABLE [dbo].[CharacterQuest]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	IdChar int ,
		CONSTRAINT FK_CharacterQuest_IdCharacter FOREIGN KEY (IdChar)
        REFERENCES Character (Id),
	IdQuest int,
		CONSTRAINT FK_CharacterQuest_IdQuest FOREIGN KEY (IdQuest)
        REFERENCES Quest (Id),
	IdStep int,
		CONSTRAINT FK_CharacterQuest_IdStep FOREIGN KEY (IdStep)
		REFERENCES QuestStep (Id),
	Validate bit,
	

)
