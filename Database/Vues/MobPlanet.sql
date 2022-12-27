CREATE VIEW [dbo].[MobPlanet]
	as select 
	mob.Id,
	mob.LocalisatorId,
	Localisator.LocPId,
	Localisator.LocAX,
	Localisator.LocAY
	from Mob 
	JOIN Localisator ON mob.LocalisatorId = Localisator.Id
	 