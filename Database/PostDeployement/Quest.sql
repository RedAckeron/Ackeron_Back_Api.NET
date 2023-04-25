/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/


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

