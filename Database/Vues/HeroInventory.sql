CREATE VIEW [dbo].[HeroInventory]
	as SELECT IdChar,IdItem,Qt
FROM HeroItem as HI
LEFT JOIN Item as I ON HI.IdItem= I.Id
	
