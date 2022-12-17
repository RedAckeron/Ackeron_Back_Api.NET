CREATE TABLE [dbo].[QuestStepLoot]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	IdQuest int not null,
		--CONSTRAINT FK_QuestStepLoot_IdQuest FOREIGN KEY (IdQuest) REFERENCES Quest (Id),
	IdStep int not null,
		CONSTRAINT FK_QuestStepLoot_IdStep FOREIGN KEY (IdStep)
		REFERENCES QuestStep (Id),
	IdItem int not null,
	Qt int not null,
	
)
