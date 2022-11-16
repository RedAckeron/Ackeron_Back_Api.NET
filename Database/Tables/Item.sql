CREATE TABLE [dbo].[Item]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	[Name] nvarchar(50),
	[Description] varchar(100),
	[Type] nvarchar(50),
	[SubType] nvarchar(50),
	[Quality] int,
	[Price] int,
	[Img] nvarchar(50),
	[Color] nvarchar(50),
	[LvlItem] int,
	[QtProduction] int,
	[TimeProduction] int,
	[TimeDelete]int,
	[MainTrigger] nvarchar(50),
	[Subtrigger] nvarchar(50)
)
