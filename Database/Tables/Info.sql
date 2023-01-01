CREATE TABLE [dbo].[Info]
(
    [Id] INT NOT NULL PRIMARY KEY identity,
	[Name] varchar(100),
	Race int,
	Sexe int,
	Classe int,
	Gold int,
	CitizenPlanet int,
	Img nvarchar(50),
	Orientation nvarchar(5) DEFAULT 'nord'
)
