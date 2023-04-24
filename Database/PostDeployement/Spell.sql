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
