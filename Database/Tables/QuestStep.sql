CREATE TABLE [dbo].[QuestStep]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	IdQuest int not null,
		CONSTRAINT FK_QuestStep_IdQuest FOREIGN KEY (IdQuest)
        REFERENCES Quest (Id),
	IdStep int,
	Name varchar(100),
	Description text,
	Validate bit not null
)
