


--injection univers
insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy)values(1,0,0,0,0,0,0,0,0,0,0,0,0);--1
insert into MapLocUnivers(name,owner)values('arkhe',0);

--injection des 3 factions , dungeon cave etc 
insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy)values(1,2,5,7,0,0,0,0,0,0,0,0,0);--2
insert into maplocsolar(LocalisatorId,name,owner)values(2,'nagma pyrgos',0);

insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy)values(1,3,12,13,0,0,0,0,0,0,0,0,0);--3
insert into maplocsolar(LocalisatorId,name,owner)values(3,'meka tackyon',0);

insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy)values(1,4,12,13,0,0,0,0,0,0,0,0,0);--4
insert into maplocsolar(LocalisatorId,name,owner)values(4,'hangus omega',0);

insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy)values(1,1,10,10,0,0,0,0,0,0,0,0,0);--5
insert into maplocsolar(LocalisatorId,name,owner)values(5,'Dungeon',0);

insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy)values(1,1,10,10,0,0,0,0,0,0,0,0,0);--6
insert into maplocsolar(LocalisatorId,name,owner)values(6,'Cave',0);


--Injection du mainland
insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy) values(1,3,12,13,1,2,6,0,2,6,0,0,0);--7
insert into maplocarea(name,Owner,IdLocalisator,maintrigger,subtrigger,imgitem,reachable,lvl,refresh)values('Rocher',0,7,'','','mainland/green/GreenRock.gif',0,10,60);
insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy) values(1,3,12,13,1,12,4,0,12,4,0,0,0);--8
insert into maplocarea(name,Owner,IdLocalisator,maintrigger,subtrigger,imgitem,reachable,lvl,refresh)values('Rocher',0,8,'','','mainland/green/GreenRock.gif',0,10,60);
insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy) values(1,3,12,13,1,8,14,0,8,14,0,0,0);--9
insert into maplocarea(name,Owner,IdLocalisator,maintrigger,subtrigger,imgitem,reachable,lvl,refresh)values('Buisson',0,9,'','','mainland/green/GreenBush.gif',0,10,60);
insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy) values(1,3,12,13,1,4,8,0,4,8,0,0,0);--10
insert into maplocarea(name,Owner,IdLocalisator,maintrigger,subtrigger,imgitem,reachable,lvl,refresh)values('Buisson',0,10,'','','mainland/green/GreenBush.gif',0,10,60);
insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy) values(1,3,12,13,1,14,10,0,14,10,0,0,0);--11
insert into maplocarea(name,Owner,IdLocalisator,maintrigger,subtrigger,imgitem,reachable,lvl,refresh)values('Rocher',0,11,'','','mainland/green/GreenRock.gif',0,10,60);
insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy) values(1,3,12,13,1,16,4,0,16,4,0,0,0);--12
insert into maplocarea(name,Owner,IdLocalisator,maintrigger,subtrigger,imgitem,reachable,lvl,refresh)values('Escalier',0,12,'tp_cave','1','mainland/green/GreenStair.gif',1,10,60);
insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy) values(1,3,12,13,1,16,4,0,6,12,0,0,0);--13
insert into maplocarea(name,Owner,IdLocalisator,maintrigger,subtrigger,imgitem,reachable,lvl,refresh)values('Escalier',0,13,'tp_cave','2','mainland/green/GreenStair.gif',1,10,60);


--injection de l entrée du dongeon dans le mainland 
insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy) values(1,3,12,13,1,16,4,0,8,8,0,0,0);--14
insert into maplocarea(name,Owner,IdLocalisator,maintrigger,subtrigger,imgitem,reachable,lvl,refresh)values('Dungeon Entrance',0,14,'','','mainland/green/dungeon_entrance/nw.gif',0,10,60);
insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy) values(1,3,12,13,1,16,4,0,9,8,0,0,0);--15
insert into maplocarea(name,Owner,IdLocalisator,maintrigger,subtrigger,imgitem,reachable,lvl,refresh)values('Dungeon Entrance',0,15,'','','mainland/green/dungeon_entrance/n.gif',0,10,60);
insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy) values(1,3,12,13,1,16,4,0,10,8,0,0,0);--16
insert into maplocarea(name,Owner,IdLocalisator,maintrigger,subtrigger,imgitem,reachable,lvl,refresh)values('Dungeon Entrance',0,16,'','','mainland/green/dungeon_entrance/ne.gif',0,10,60);
insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy) values(1,3,12,13,1,16,4,0,8,9,0,0,0);--17
insert into maplocarea(name,Owner,IdLocalisator,maintrigger,subtrigger,imgitem,reachable,lvl,refresh)values('Dungeon Entrance',0,17,'','','mainland/green/dungeon_entrance/w.gif',0,10,60);
insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy) values(1,3,12,13,1,16,4,0,10,9,0,0,0);--18
insert into maplocarea(name,Owner,IdLocalisator,maintrigger,subtrigger,imgitem,reachable,lvl,refresh)values('Dungeon Entrance',0,18,'','','mainland/green/dungeon_entrance/e.gif',0,10,60);
insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy) values(1,3,12,13,1,16,4,0,9,9,0,0,0);--19
insert into maplocarea(name,Owner,IdLocalisator,maintrigger,subtrigger,imgitem,reachable,lvl,refresh)values('Dungeon Entrance',0,19,'tp_dungeon','1','mainland/green/dungeon_entrance/c.gif',1,10,60);

--Ajoute des items 
insert into item values('1 Rubis','1 Rubis, la monnaie du royaume',1,1,1,99,10,'item/rubis_1.gif','yellow',1,1,60,600,'no','no');
insert into item values('5 Rubis','1 paquet de 5 Rubis, la monnaie du royaume',1,1,1,99,10,'item/rubis_5.gif','blue',1,1,60,600,'no','no');
insert into item values('10 Rubis','1 paquet de 10 Rubis, la monnaie du royaume',1,1,1,99,10,'item/rubis_10.gif','red',1,1,60,600,'no','no');
insert into item values('20 Rubis','1 paquet de 20 Rubis, la monnaie du royaume',1,1,1,99,10,'item/rubis_20.gif','purple',1,1,60,600,'no','no');
insert into item values('50 Rubis','1 paquet de 50 Rubis, la monnaie du royaume',1,1,1,99,10,'item/rubis_50.gif','grey',1,1,60,600,'no','no');
insert into item values('100 Rubis','1 paquet de 100 Rubis, la monnaie du royaume',1,1,1,99,10,'item/rubis_100.gif','gold',1,1,60,600,'no','no');
insert into item values('Potion de vie mineur','petit poition de vie qui rend 10 pv',1,1,1,99,10,'item/potion_pv.gif','yellow',1,1,60,600,'no','no');
insert into item values('Potion de mana mineur','petit poition de mana qui rend 10 pm',1,1,1,99,10,'item/potion_pm.gif','yellow',1,1,60,600,'no','no');



--Insertion des quest
insert into quest (name,title,description,validate) values ('dungeon','Le dongeon','Serrez vous assez brave pour descendre les 100 etages du dongeon',0);
insert into queststep (idquest,idstep,name,description,validate) values (1,1,'Etage -10','Descendez jusque au 10 eme sous sol et decouvrez le gardien du premier tresor',0);
insert into queststep (idquest,idstep,name,description,validate) values (1,2,'Etage -20','test',0);
insert into queststep (idquest,idstep,name,description,validate) values (1,3,'Etage -30','test',0);
insert into queststep (idquest,idstep,name,description,validate) values (1,4,'Etage -40','test',0);
insert into queststep (idquest,idstep,name,description,validate) values (1,5,'Etage -50','test',0);
insert into queststep (idquest,idstep,name,description,validate) values (1,6,'Etage -60','test',0);
insert into queststep (idquest,idstep,name,description,validate) values (1,7,'Etage -70','test',0);
insert into queststep (idquest,idstep,name,description,validate) values (1,8,'Etage -80','',0);
insert into queststep (idquest,idstep,name,description,validate) values (1,9,'Etage -90','',0);
insert into queststep (idquest,idstep,name,description,validate) values (1,10,'Etage -100','',0);

insert into quest (name,title,description,validate) values ('craft_intro','La Fabrication','Introduction a la collecte et a la fabrication d objets',0);
insert into queststep (idquest,idstep,name,description,validate) values (2,1,'Recuperation de 3 bloc de pierre','',0);
insert into queststep (idquest,idstep,name,description,validate) values (2,2,'Recuperation de 2 planches','',0);
insert into queststep (idquest,idstep,name,description,validate) values (2,3,'Assemblage','',0);



insert into spell values('Coup de poing mineur','Envoi un coup de poing sur la cible 10 Hit',0,1000,0,0,0,0,0,0,0,10,0,0);
insert into spell values('Coup de poing majeur','Envoi un coup de poing sur la cible 30 Hit',0,1000,0,0,0,0,0,0,0,30,0,0);

insert into spell values('Flame Wave','envoi une boule de feu qui vas bruler 10 Hit ',0,1000,0,10,0,0,0,0,0,0,0,0);
insert into spell values('Rain of Fire','envoi une boule de feu qui vas bruler 10 Hit ',0,1000,0,10,0,0,0,0,0,0,0,0);
insert into spell values('Flare','envoi une boule de feu qui vas bruler 10 Hit ',0,1000,0,10,0,0,0,0,0,0,0,0);
insert into spell values('FireStorm','envoi une boule de feu qui vas bruler 30 Hit',0,1000,0,30,0,0,0,0,0,0,0,0);
insert into spell values('Inferno','envoi une boule de feu qui vas bruler 10 Hit ',0,1000,0,10,0,0,0,0,0,0,0,0);
insert into spell values('Meteor','envoi une boule de feu qui vas bruler 100 Hit',0,1000,0,100,0,0,0,0,0,0,0,0);

insert into spell values('soin mineur','envoi un soin qui rend 10 Heal',0,1000,0,0,0,0,10,0,0,0,0,0);
insert into spell values('soin majeur','envoi un soins qui rend 30 Heal',0,1000,0,0,0,0,30,0,0,0,0,0);

insert into spell values('Vol de vie mineur','Sort de drain de vie qui retire 10 Hit',0,1000,0,0,0,0,10,0,0,0,0,0);
insert into spell values('Vol de vie majeur','Sort de drain de vie qui retire 30 Hit',0,1000,0,0,0,0,30,0,0,0,0,0);




--insert into HeroItem (IdChar,IdItem,Qt)values(1,1,10);
--insert into HeroItem (IdChar,IdItem,Qt)values(1,2,5);
--insert into HeroItem (IdChar,IdItem,Qt)values(1,3,9);
--insert into HeroItem (IdChar,IdItem,Qt)values(1,4,12);
--insert into HeroItem (IdChar,IdItem,Qt)values(1,5,12);
--insert into HeroItem (IdChar,IdItem,Qt)values(1,6,12);
