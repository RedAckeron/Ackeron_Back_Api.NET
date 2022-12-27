CREATE VIEW [dbo].[ViewAreaLoc]
	as select 
	MapLocArea.Id,
	MapLocArea.Name,
	MapLocArea.Owner,
	MapLocArea.MainTrigger,
	MapLocArea.SubTrigger,
	MapLocArea.ImgItem,
	MapLocArea.Reachable,
	MapLocArea.Lvl,
	MapLocArea.Refresh,
	Localisator.LocPId,
	Localisator.LocAX,
	Localisator.LocAY
	from MapLocArea 
	JOIN Localisator ON MapLocArea.IdLocalisator= Localisator.Id
