insert into [Character] values('Link',0,0,0,0,1666362817);
insert into CharacterLoc(IdChar,LocU,LocS,LocP,LocA,LocA_X,LocA_Y)values(1,1,1,1,1,10,15);
insert into CharacterStat values(1,1,5,20,0,80,100,30,50,0);
insert into CharacterPower values(1,10,10,10,10,10,10,10,10,10,10);
insert into CharacterResist values(1,10,10,10,10,10,10,10,10,10,10);

insert into Item values('Kredit','[Kr] - La monnaie du royaume',1,1,99,10,'img','yellow',1,1,60,600,'no','no');
insert into Item values('Potion de vie mineur','Petit poition de vie qui rend 10 Pv',1,1,99,10,'img','yellow',1,1,60,600,'no','no');

insert into Spell values('Boule de feu Mineur','Envoi une boule de feu qui vas tout bruler dans un rayon de 1 case',10);
insert into Spell values('Boule de feu Majeur','Envoi une boule de feu qui vas tout bruler dans un rayon de 3 cases',30);
insert into Spell values('Soin mineur','Envoi un soin qui rend 100% de Pv',10);
insert into Spell values('Soin majeur','Envoi un soins qui rend 300% de Pv',30);

insert into CharacterItem values(1,1,1);
insert into CharacterItem values(1,2,1);

insert into CharacterSpell values(1,1);
insert into CharacterSpell values(1,2);
insert into CharacterSpell values(1,3);
insert into CharacterSpell values(1,4);


insert into Quest values('L eveil des Nagmas','Introduction a la quest des Nagmas',0);

insert into QuestStep values(1,'Le reveil d Ackeron','Dans le teritoire des nagmas , un volcan se reveil se qui provoque l emergence du Ki chez de plus en plus d habitant',0);
insert into QuestStep values(1,'La colere d Ackeron','Les Nagmien meurent en masse , et visiblement les survivants recupere les Ki des victimes se qui les rend plus fort',0);

insert into QuestStepLoot values(1,1,1,10);
insert into QuestStepLoot values(1,2,1,20);

insert into CharacterQuest values(1,1,1,0);