
insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy)values(1,0,0,0,0,0,0,0,0,0,0,0,0);--1
insert into MapLocUnivers(name,owner)values('arkhe',1);

insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy)values(1,1,10,10,0,0,0,0,0,0,0,0,0);--2
insert into maplocsolar(LocalisatorId,name,owner)values(2,'inferno',1);

insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy)values(1,2,5,7,0,0,0,0,0,0,0,0,0);--3
insert into maplocsolar(LocalisatorId,name,owner)values(3,'alpha',1);

insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy)values(1,3,12,13,0,0,0,0,0,0,0,0,0);--4
insert into maplocsolar(LocalisatorId,name,owner)values(4,'anthares',1);


insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy) values(1,1,12,13,1,10,16,0,0,0,0,0,0);--5
insert into maplocplanet(name,owner,LocalisatorId)values('nagma pyrgos',0,5);

insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy) values(1,2,12,13,2,8,6,0,0,0,0,0,0);--6
insert into maplocplanet(name,owner,LocalisatorId)values('meka tackyon',0,6);

insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy) values(1,3,12,13,3,12,3,0,0,0,0,0,0);--7
insert into maplocplanet(name,owner,LocalisatorId)values('hangus omega',0,7);

insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy) values(1,3,12,13,1,2,6,0,2,6,0,0,0);--8
insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy) values(1,3,12,13,1,12,4,0,12,4,0,0,0);--9
insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy) values(1,3,12,13,1,8,14,0,8,14,0,0,0);--10
insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy) values(1,3,12,13,1,4,8,0,4,8,0,0,0);--11
insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy) values(1,3,12,13,1,14,10,0,14,10,0,0,0);--12
insert into Localisator(LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZx,LocZy) values(1,3,12,13,1,16,4,0,16,4,0,0,0);--13


insert into maplocarea(name,Owner,IdLocalisator,maintrigger,subtrigger,imgitem,reachable,lvl,refresh)values('Rocher',0,8,'mt','st','GreenRock.gif',0,10,60);
insert into maplocarea(name,Owner,IdLocalisator,maintrigger,subtrigger,imgitem,reachable,lvl,refresh)values('Rocher',0,9,'mt','st','GreenRock.gif',0,10,60);
insert into maplocarea(name,Owner,IdLocalisator,maintrigger,subtrigger,imgitem,reachable,lvl,refresh)values('Buisson',0,10,'mt','st','GreenBush.gif',0,10,60);
insert into maplocarea(name,Owner,IdLocalisator,maintrigger,subtrigger,imgitem,reachable,lvl,refresh)values('Buisson',0,11,'mt','st','GreenBush.gif',0,10,60);
insert into maplocarea(name,Owner,IdLocalisator,maintrigger,subtrigger,imgitem,reachable,lvl,refresh)values('Rocher',0,12,'mt','st','GreenRock.gif',0,10,60);
insert into maplocarea(name,Owner,IdLocalisator,maintrigger,subtrigger,imgitem,reachable,lvl,refresh)values('Escalier',0,13,'mt','st','GreenStair.gif',1,10,60);

insert into item values('kredit','[kr] - la monnaie du royaume',1,1,99,10,'img','yellow',1,1,60,600,'no','no');
insert into item values('potion de vie mineur','petit poition de vie qui rend 10 pv',1,1,99,10,'img','yellow',1,1,60,600,'no','no');

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



--insert into characteritem values(1,1,1);
--insert into characteritem values(1,2,1);

--insert into characterspell values(1,1);
--insert into characterspell values(1,2);
--insert into characterspell values(1,3);
--insert into characterspell values(1,4);

--insert into Quest (IdQuest,Name,Description,Validate) values (1,'L eveil du Ki Nagma','l histoire d un gamin qui vas decouvrire l existance du Ki',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (1,1,'Le grand Chaos ki viens','Dans le teritoire des nagmas , un volcan se reveil se qui provoque l emergence du Ki chez de plus en plus d habitant',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (1,2,'kikela','La naissance du Ki',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (1,3,'La communauté de nécromantien ki est pas gentil','',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (1,4,'Kiproco','',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (1,5,'La Transformation du Ki','Le ki prend ses 5 formes physique (CAC DIStant Tank Healer Craft)',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (1,6,'Ki sait comment sa marche','Investigation et decouverte du fonctionnement',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (1,7,'07 - Empty','',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (1,8,'08 - Empty','',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (1,9,'09 - Empty','',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (1,10,'10 - Empty','',0);


--insert into Quest (IdQuest,Name,Description,Validate) values (2,'L explosion du Bot Meka','l histoire d un gamin pauvre qui recuperer un bot endomager pour en faire son compagnon',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (2,1,'Achat','Le rachat du Bot detruit aux gnomes',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (2,2,'Devis','Evalutation des degats et collecte des composants',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (2,3,'Taxes','Les bandits de grand chemin',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (2,4,'Déduction','La recuperation des pieces',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (2,5,'Rembourssement','Assemblage et activation du bot (CAC DIStant Tank Healer Craft)',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (2,6,'06 - Empty','',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (2,7,'07 - Empty','',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (2,8,'08 - Empty','',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (2,9,'09 - Empty','',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (2,10,'10 - Empty','',0);

--insert into Quest (IdQuest,Name,Description,Validate) values (3,'L appel de l Hangus','l histoire d un gamin qui perd son chat dans un accident et entend un animal l appeler',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (3,1,'La découvertede l oeuf innatendu','',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (3,2,'l inconnus qui en sait trop','',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (3,3,'la confrerie des poules','',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (3,4,'la recuperation de l oeuf','',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (3,5,'Eclosion','',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (3,6,'06 - Empty','',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (3,7,'07 - Empty','',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (3,8,'08 - Empty','',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (3,9,'09 - Empty','',0);
--insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (3,10,'10 - Empty','',0);

--insert into QuestStepLoot values(1,1,1,10);
--insert into QuestStepLoot values(1,2,1,20);

--insert into CharacterQuest values(1,1,1,0);

