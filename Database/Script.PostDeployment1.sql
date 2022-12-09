insert into [character] values('admin',0,0,0,0,1666362817);

insert into characterloc(idchar,locu,locs,locp,loca,loca_x,loca_y)values(1,1,1,1,1,10,15);
insert into characterstat values(1,1,5,20,0,80,100,30,50,0);
insert into characterpower values(1,10,10,10,10,10,10,10,10,10,10);
insert into characterresist values(1,10,10,10,10,10,10,10,10,10,10);

insert into item values('kredit','[kr] - la monnaie du royaume',1,1,99,10,'img','yellow',1,1,60,600,'no','no');
insert into item values('potion de vie mineur','petit poition de vie qui rend 10 pv',1,1,99,10,'img','yellow',1,1,60,600,'no','no');

insert into spell values('boule de feu mineur','envoi une boule de feu qui vas tout bruler dans un rayon de 1 case',10);
insert into spell values('boule de feu majeur','envoi une boule de feu qui vas tout bruler dans un rayon de 3 cases',30);
insert into spell values('soin mineur','envoi un soin qui rend 100% de pv',10);
insert into spell values('soin majeur','envoi un soins qui rend 300% de pv',30);

insert into characteritem values(1,1,1);
insert into characteritem values(1,2,1);

insert into characterspell values(1,1);
insert into characterspell values(1,2);
insert into characterspell values(1,3);
insert into characterspell values(1,4);

insert into Quest (IdQuest,Name,Description,Validate) values (1,'L eveil du Ki Nagma','l histoire d un gamin qui vas decouvrire l existance du Ki',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (1,1,'Le grand Chaos ki viens','Dans le teritoire des nagmas , un volcan se reveil se qui provoque l emergence du Ki chez de plus en plus d habitant',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (1,2,'kikela','La naissance du Ki',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (1,3,'La communauté de nécromantien ki est pas gentil','',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (1,4,'Kiproco','',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (1,5,'La Transformation du Ki','Le ki prend ses 5 formes physique (CAC DIStant Tank Healer Craft)',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (1,6,'Ki sait comment sa marche','Investigation et decouverte du fonctionnement',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (1,7,'07 - Empty','',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (1,8,'08 - Empty','',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (1,9,'09 - Empty','',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (1,10,'10 - Empty','',0);


insert into Quest (IdQuest,Name,Description,Validate) values (2,'L explosion du Bot Meka','l histoire d un gamin pauvre qui recuperer un bot endomager pour en faire son compagnon',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (2,1,'Achat','Le rachat du Bot detruit aux gnomes',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (2,2,'Devis','Evalutation des degats et collecte des composants',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (2,3,'Taxes','Les bandits de grand chemin',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (2,4,'Déduction','La recuperation des pieces',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (2,5,'Rembourssement','Assemblage et activation du bot (CAC DIStant Tank Healer Craft)',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (2,6,'06 - Empty','',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (2,7,'07 - Empty','',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (2,8,'08 - Empty','',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (2,9,'09 - Empty','',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (2,10,'10 - Empty','',0);

insert into Quest (IdQuest,Name,Description,Validate) values (3,'L appel de l Hangus','l histoire d un gamin qui perd son chat dans un accident et entend un animal l appeler',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (3,1,'La découvertede l oeuf innatendu','',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (3,2,'l inconnus qui en sait trop','',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (3,3,'la confrerie des poules','',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (3,4,'la recuperation de l oeuf','',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (3,5,'Eclosion','',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (3,6,'06 - Empty','',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (3,7,'07 - Empty','',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (3,8,'08 - Empty','',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (3,9,'09 - Empty','',0);
insert into QuestStep (IdQuest,IdStep,Name,Description,Validate) values (3,10,'10 - Empty','',0);

insert into QuestStepLoot values(1,1,1,10);
insert into QuestStepLoot values(1,2,1,20);

insert into CharacterQuest values(1,1,1,0);

insert into MapLocUnivers(name,Owner)values('Arkhe',1);

insert into MapLocSolar(LocU,name,Owner)values(1,'Inferno',1);
insert into MapLocSolar(LocU,name,Owner)values(1,'Alpha',1);
insert into MapLocSolar(LocU,name,Owner)values(1,'Anthares',1);

insert into MapLocPlanet(name,LocU,LocS,LocX,LocY)values('Nagma Pyrgos',1,1,10,10);
insert into MapLocPlanet(name,LocU,LocS,LocX,LocY)values('Meka Tackyon',1,2,10,10);
insert into MapLocPlanet(name,LocU,LocS,LocX,LocY)values('Hangus Omega',1,3,10,10);

insert into MapLocArea(name,LocU,LocS,LocP,LocX,LocY,MainTrigger,SubTrigger,ImgItem,Reachable,Lvl,Refresh)values('Rocher',1,1,1,5,5,'mt','st','rocher.gif',0,10,60);
insert into MapLocArea(name,LocU,LocS,LocP,LocX,LocY,MainTrigger,SubTrigger,ImgItem,Reachable,Lvl,Refresh)values('Rocher',1,1,1,3,7,'mt','st','rocher.gif',0,10,60);
insert into MapLocArea(name,LocU,LocS,LocP,LocX,LocY,MainTrigger,SubTrigger,ImgItem,Reachable,Lvl,Refresh)values('Buisson',1,1,1,1,9,'mt','st','bush.gif',0,10,60);
insert into MapLocArea(name,LocU,LocS,LocP,LocX,LocY,MainTrigger,SubTrigger,ImgItem,Reachable,Lvl,Refresh)values('Buisson',1,1,1,9,1,'mt','st','bush.gif',0,10,60);
insert into MapLocArea(name,LocU,LocS,LocP,LocX,LocY,MainTrigger,SubTrigger,ImgItem,Reachable,Lvl,Refresh)values('Buisson',1,1,1,7,3,'mt','st','bush.gif',0,10,60);
insert into MapLocArea(name,LocU,LocS,LocP,LocX,LocY,MainTrigger,SubTrigger,ImgItem,Reachable,Lvl,Refresh)values('Stair',1,1,1,7,9,'mt','st','stair.gif',1,10,60);