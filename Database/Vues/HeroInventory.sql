CREATE VIEW [dbo].[HeroInventory]
	as SELECT HI.IdChar,HI.IdItem,HI.Qt
FROM HeroItem as HI
LEFT JOIN Item as I ON HI.IdItem= I.Id
	
