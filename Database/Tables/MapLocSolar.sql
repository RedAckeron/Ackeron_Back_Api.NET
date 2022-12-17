﻿CREATE TABLE [dbo].[MapLocSolar]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	[LocalisatorId] int,
	CONSTRAINT FK_MapLocSolar_Localisator FOREIGN KEY (LocalisatorId)
    REFERENCES Localisator (Id),
	[Name] nvarchar(50),
	[Owner] int,
	
	
)
