CREATE TABLE [dbo].[Quest]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	[Name] varchar(25),
	[Title] varchar(50),
	[Description] varchar(100),
	[Validate] bit
)
