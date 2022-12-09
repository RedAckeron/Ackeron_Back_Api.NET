CREATE TABLE [dbo].[Quest]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	IdQuest int ,
	Name varchar(50),
	Description varchar(100),
	Validate bit
)
