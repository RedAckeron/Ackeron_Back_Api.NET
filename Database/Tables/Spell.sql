CREATE TABLE [dbo].[Spell]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	name varchar(50),
	Description varchar(100),
	XpMinAcquiring int,
	Cooldown int,
	eau int,
	feu int,
	air int,
	terre int,
	lumiere int,
	tenebre int,
	tranchant int,
	ecrasant int,
	percant int,
	poison int
)
