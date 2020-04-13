create database EFP_Final;
use EFP_Final;
--
--DESKTOP-2PAL5U2\Ali
--
create table Formateur(
	numfrm int primary key,
	matricule varchar(20) unique,
	cin varchar(20) unique,
	nomfrm varchar(20),
	prenomfrm varchar(20),
	dateN date,
	dateEmbauche date,
	grade varchar(20),
	statut varchar(20),
	CONSTRAINT CHK_statut CHECK (statut='Statutaire' or statut='Vacataire'),
);

insert into Formateur values(1,'M1','C1','Karami','Alami','1987/01/01','2010/07/01','G1','Statutaire');
insert into Formateur values(2,'M2','C2','Metouali','Hassane','1987/01/01','2011/07/01','G2','Statutaire');
insert into Formateur values(3,'M3','C3','LMbarki','Choaib','1987/01/01','2013/07/01','G3','Statutaire');
insert into Formateur values(4,'M4','C4','Saadani','Hamid','1987/01/01','2009/07/01','G4','Vacataire');
insert into Formateur values(5,'M5','C5','Khalidi','Jamal','1987/01/01','2010/07/01','G5','Statutaire');
insert into Formateur values(6,'M6','C6','Fatihi','Mohammed','1987/01/01','2014/07/01','G6','Vacataire');
insert into Formateur values(7,'M7','C7','Jouali','Karim','1987/01/01','2013/07/01','G7','Statutaire');
insert into Formateur values(8,'M8','C8','Belmeknassi','Ahmed','1987/01/01','2012/07/01','G8','Vacataire');
insert into Formateur values(9,'M9','C9','Massaoudi','Amine','1987/01/01','2011/07/01','G9','Statutaire');
insert into Formateur values(10,'M10','C10','Rahimi','Soufien','1987/01/01','2009/07/01','G10','Vacataire');



--delete Formateur where numfrm=1

select * from Formateur where numfrm=1
----------------------------------------------
create table Filiere(
	numFlr varchar(20) primary key,
	nomFlr varchar(50),
	niveauFlr varchar(20),
	typeFlr varchar(50),
		CONSTRAINT CHK_typeFlr CHECK (typeFlr='Résidentiel' or typeFlr='Alterné'),
);
--alter table Filiere
--alter column typeFlr varchar(20)

insert into Filiere values('TDI','Dev info','TS','Résidentiel');

insert into Filiere values('TRI','Res info','TS','Résidentiel');

insert into Filiere values('TSGE','Ges Entre','TS','Résidentiel');

insert into Filiere values('TSC','Comm','TS','Résidentiel');



select * from Filiere
----------------------------------------------
create table Module(
	numMdl int,
	numflr varchar(20),
	foreign key (numflr) references Filiere(numflr),
	anneeMdl varchar(10),
	nomMdl varchar(20),
	MH int,
	coeficientMdl int,
	semestreMdl varchar(2),
	 primary key(numMdl,numflr)
);
insert into Module values(1,'TDI','1ere année','M05',180,3,'S1');
insert into Module values(2,'TDI','2éme année','MO8',140,4,'S3');
insert into Module values(3,'TDI','2éme année','MO9',140,4,'S4');

insert into Module values(4,'TRI','1ére année','M05',180,3,'S2');
insert into Module values(4,'TRI','2ére année','M012',180,3,'S3');

insert into Module values(5,'TSGE','1ére année','MO4',140,4,'S2');
insert into Module values(6,'TSGE','2éme année','MO10',140,4,'S4');

insert into Module values(7,'TSC','1ére année','MO2',140,4,'S1');
insert into Module values(8,'TSC','2éme année','MO11',140,4,'S3');

--delete module where numMdl=2and numflr='TRI1'
select * from Module
----------------------------------------------
create table Groupe(
	numGrp int primary key,
	nomGrp varchar(20),
	numflr varchar(20) references Filiere(numflr),
	annee varchar(2)
);
--alter table Groupe
--alter column anneeGrp varchar(2)
insert into Groupe values(1,'TDI101','TDI','1');
insert into Groupe values(2,'TDI201','TDI','2');

insert into Groupe values(3,'TRI101','TRI','1');
insert into Groupe values(4,'TDI201','TRI','2');

insert into Groupe values(5,'TSGE101','TSGE','1');
insert into Groupe values(6,'TSGE201','TSGE','2');

insert into Groupe values(7,'TSC101','TSC','1');
insert into Groupe values(8,'TSC201','TSC','2');



select * from groupe

delete Groupe
where numgrp=1
----------------------------------------------
--create trigger NomGroupe
--ON Groupe
--for insert
--as
--	declare @anneeGrp varchar(2), @numFlr varchar(20), @nom varchar(20);
--	begin
--	set @numFlr =(select numflr from inserted);
--	set @anneeGrp =(select anneeGrp from inserted);
--	set @nom =(select nomGrp from inserted);
--	set @nom=(@numFlr+@anneeGrp);
--	update groupe
--	set nomGrp=@nom
--	where numGrp in (select numGrp from inserted);
--	print @nom;
--	end;
----------------------------------------------
select st.cin,st.numStg,st.nomStg,st.prenomStg,st.dateNStg,gr.nomGrp,gr.anneeGrp,fl.nomFlr,fl.niveauFlr 
from stagaire st join groupe gr on st.numGrp=gr.numGrp join Filiere fl on fl.numflr=gr.numflr 
where cin='BJ123'

select st.cin,st.numStg,st.nomStg,st.prenomStg,st.dateNStg,gr.nomGrp,gr.anneeGrp,fl.nomFlr,fl.niveauFlr 
                        from stagaire st join groupe gr on st.numGrp = gr.numGrp join Filiere fl on fl.numflr = gr.numflr
                        where cin = 'BJ123'
--------------
create table Stagaire(
	numStg int primary key,
	nomStg varchar(20),
	prenomStg varchar(20),
	dateNStg date,
	numGrp int references groupe(numGrp),
	Cin varchar(30) unique,
);
select stg.nomStg,stg.prenomStg,stg.cin,stg.dateNStg from stagaire stg join groupe gp on stg.numGrp=gp.numGrp 
where gp.nomGrp='tdi201'
select * from stagaire where cin='bj123'

select mdl.nomMdl,mdl.MH,coeficientMdl,mdl.anneeMdl,semestreMdl from Stagaire st join groupe gp on st.numGrp=gp.numGrp join Filiere flr on gp.numflr=flr.numFlr join Module mdl on flr.numFlr=mdl.numflr
where nomGrp='TDI202'
select * from module

select mdl.nomMdl,mdl.MH,coeficientMdl,mdl.anneeMdl,semestreMdl  from Module mdl join groupe gp on mdl.numflr=gp.numflr where gp.nomGrp='TDI101'
select *from Stagaire st join groupe gp on st.numGrp=gp.numGrp join Filiere flr on gp.numflr=flr.numFlr join Module mdl on flr.numFlr=mdl.numflr


select flr.nomFlr,gp.nomGrp,mdl.nomMdl,mdl.MH,coeficientMdl,mdl.anneeMdl,semestreMdl from Stagaire st join groupe gp on st.numGrp=gp.numGrp join Filiere flr on gp.numflr=flr.numFlr join Module mdl on flr.numFlr=mdl.numflr
where cin='bj123'
alter table Stagaire
add cin varchar(20);

insert into Stagaire values(1,'OurrAmi','Ali','1997/09/16',1,'bj123');
insert into Stagaire values(2,'Banoun','Badr','1998/01/1',2,'bj200');
insert into Stagaire values(3,'Zniti','Anass','1996/09/16',2,'Zni396');
insert into Stagaire values(4,'Omari','Adil','1997/09/16',2,'OmAd497');
insert into Stagaire values(5,'Ziyach','Hakim','1997/09/16',3,'ZiHa597');
insert into Stagaire values(6,'Hakimi','Achraf','1997/09/16',3,'bj600');
insert into Stagaire values(7,'Zerouali','Zakaria','1997/09/16',4,'bj700');
insert into Stagaire values(8,'Aouhaki','Anass','1997/09/16',4,'bj800');
insert into Stagaire values(9,'Andaloussi','Ziyad','1997/09/16',5,'bj900');
insert into Stagaire values(10,'Achmaoui','Iliass','1997/09/16',5,'bj1000');
insert into Stagaire values(11,'Elouaai','Yazid','1997/09/16',6,'bj1100');
insert into Stagaire values(12,'Kadouri','Badr','1997/09/16',6,'bj1200');
insert into Stagaire values(13,'Farahat','Anouar','1997/09/16',7,'bj1300');
insert into Stagaire values(14,'Sedraty','Mohammed','1997/09/16',7,'bj1400');
insert into Stagaire values(15,'Tihadi','Youssef','1997/09/16',2,'bj1500');
insert into Stagaire values(16,'Azizi','Anas','1997/09/16',8,'bj1600');

select * from Stagaire

update Stagaire
set numGrp=1
where NumStg=2

alter table Stagaire
DROP  column cin
----------------------------------------------
create table EFM_Planification(
	numMdl int, 
	numFlr varchar(20), 
	numGrp int,
	date_prevue date,
	date_efective date,
	foreign key (numMdl,numFlr) references Module(numMdl,numFlr),
	foreign key (numGrp) references Groupe(numGrp),
	primary key(numMdl,numFlr,numGrp),
);
----------
select mdl.nomMdl,flr.nomFlr,gp.nomGrp, ep.date_prevue,ep.date_efective from EFM_Planification ep join Module mdl on ep.numMdl=mdl.numMdl join Filiere flr on ep.numFlr=flr.numFlr join Groupe gp on ep.numGrp=gp.numGrp
where flr.numFlr=1
----------

insert into EFM_Planification values(1,'TDI',1,'2019/04/10','2019/04/11');
insert into EFM_Planification values(4,'TRI',3,'2019/04/10','2019/04/11');
select * from EFM_Planification
----------------------------------------------
create table Affectation(
	numAff int primary key,
	numGrp int,
	numFlr varchar(20),
	numMdl int,
	numFrm int,
	dateAff date,
	foreign key (numGrp) references Groupe(numGrp),
	foreign key (numMdl,numFlr) references Module(numMdl,numFlr),
	foreign key (numFrm) references Formateur(numfrm),
);
select fr.nomfrm, fr.cin, flr.nomFlr, gp.nomGrp from formateur fr join affectation aff on fr.numFrm=aff.numFrm join groupe gp on aff.numGrp=gp.numGrp join Filiere flr on aff.numFlr=flr.numFlr 
where fr.nomfrm='N3'
select * from affectation aff 

insert into Affectation values(1,1,'TDI',1,1,'2018/11/01');
insert into Affectation values(2,3,'TRI',4,1,'2018/11/01');
select * from Affectation
----------------------------------------------
create table Seance(
	numSc int primary key,
	numAff int references Affectation(numAff),
	dateSc date,
	duree int,
	salle int,
);

SELECT DATEPART (wk, 2018/11/01) AS Week,

Sum(duree) AS duree

FROM Seance
where numSc=1
Group By DATEPART (wk,2018/11/01);

select gp.nomGrp,sc.dateSc,sc.duree,sc.salle,fr.nomfrm from Seance sc join Affectation af on sc.numAff=af.numAff join Groupe gp on af.numGrp=gp.numGrp join Formateur fr on af.numFrm=fr.numfrm
where gp.nomGrp='TDI201'

insert into Seance values(1,1,'2018/11/01',5,1);
select * from Seance
----------------------------------------------
create table Absence(
	numSc int references Seance(numSc),
	NumStg int references Stagaire(NumStg),
	primary key(numSc,NumStg),
);
----
	select * 
	from Absence ab join Seance sc on ab.numSc=sc.numSc join Stagaire st on st.numStg=ab.NumStg join Groupe gp on st.numGrp=gp.numGrp 
	where ab.NumStg=1 or ab.numSc=1

	select st.cin,ab.numSc,ab.numStg,sc.salle,st.nomStg,st.prenomStg,sc.dateSc,sc.duree,gp.nomGrp
	from Absence ab join Seance sc on ab.numSc=sc.numSc join Stagaire st on st.numStg=ab.NumStg join Groupe gp on st.numGrp=gp.numGrp 
	where st.cin='bj123'
-----

select st.cin,ab.numSc,ab.numStg,sc.salle,st.nomStg,st.prenomStg,sc.dateSc,sc.duree,gp.nomGrp
	from Absence ab join Seance sc on ab.numSc=sc.numSc join Stagaire st on st.numStg=ab.NumStg join Groupe gp on st.numGrp=gp.numGrp 
	where gp.NomGrp='TDI01'
-------

insert into Absence values(1,1);
insert into Absence values(1,2);
select * from Absence

------------------------------------------------
select * from Formateur
select * from Filiere
select * from Module
select * from Groupe
select * from Stagaire
select * from EFM_Planification
select * from Affectation
select * from Seance
select * from Absence




