CREATE TABLE [dbo].[MapLocArea]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	Name nvarchar(50),
	Owner int,
	IdLocalisator int,
	    CONSTRAINT [FK_MapLocArea_IdLocalisator] FOREIGN KEY ([IdLocalisator]) REFERENCES [dbo].[Localisator] ([Id]),
	MainTrigger nvarchar(50),
	SubTrigger nvarchar(50),
	ImgItem nvarchar(100),
	Reachable bit,
	Lvl int,
	Refresh int
)
