CREATE TABLE [dbo].[MapLocPlanet] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [name]           VARCHAR (50)  NULL,
    [owner]          INT           NULL DEFAULT 1,
    LocalisatorId int,
    	    CONSTRAINT [FK_MapLocPlanet_IdLocalisator] FOREIGN KEY ([LocalisatorId]) REFERENCES [dbo].[Localisator] ([Id]),
    [TypeItem]       VARCHAR (3)   NULL DEFAULT 'pla',
    [ImgItem]        NVARCHAR (50) NULL DEFAULT 'planet.gif',
    [Lvl]            INT           NULL DEFAULT 0,
    [Size]           INT           NULL DEFAULT 0,
    [Presentation]   TEXT          NULL DEFAULT 'Bienvenu sur notre planet',
    [Faction]        INT           NULL DEFAULT 0,
    [TxShop]         INT           NULL DEFAULT 0,
    [TxArmy]         INT           NULL DEFAULT 0,
    [PriceEmptyArea] INT           NULL DEFAULT 0,
    [CaisseShop]     INT           NULL DEFAULT 0,
    [CaisseArmy]     INT           NULL DEFAULT 0,
    [CaisseAll]      INT           NULL DEFAULT 0,
    [PriceWork]      INT           NULL DEFAULT 0,
    [BgroundImg]     NVARCHAR (50) NULL DEFAULT 'img.gif',
    PRIMARY KEY CLUSTERED ([Id] ASC),
    
);

