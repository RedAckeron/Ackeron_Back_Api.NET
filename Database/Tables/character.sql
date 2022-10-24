CREATE TABLE [dbo].[Character]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	[name] varchar(100),
	race int,
	sexe int,
	class int,
	CitizenPlanet int,
 	TsCreation int
)
