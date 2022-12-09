CREATE TABLE [dbo].[MapLocZone]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	Name nvarchar(50),
	Owner int,
	LocU int,
	LocS int,
	LocP int,
	LocA int,
	LocX int,
	Locy int,
)
