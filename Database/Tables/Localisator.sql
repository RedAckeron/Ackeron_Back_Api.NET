CREATE TABLE [dbo].[Localisator]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	LocUId int null,
	
	LocSId int null,
	CONSTRAINT FK_Localisator_SID FOREIGN KEY (LocSId)
    REFERENCES MapLocSolar(Id),
	LocSX int null DEFAULT 1,
	LocSY int null DEFAULT 1,
	LocPId int null,
	CONSTRAINT FK_Localisator_PID FOREIGN KEY (LocPId)
    REFERENCES MapLocPlanet(Id),
	LocPX int null DEFAULT 1,
	LocPY int null DEFAULT 1,
	LocAId int null,
	CONSTRAINT FK_Localisator_AID FOREIGN KEY (LocAId)
    REFERENCES MapLocArea(Id),
	LocAX int null DEFAULT 1,
	LocAY int null DEFAULT 1,
	LocZId int null,
	CONSTRAINT FK_Localisator_ZID FOREIGN KEY (LocPId)
    REFERENCES MapLocZone(Id),
	LocZX int null DEFAULT 1,
	LocZY int null DEFAULT 1
)
