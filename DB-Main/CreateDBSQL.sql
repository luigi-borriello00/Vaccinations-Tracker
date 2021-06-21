-- *********************************************
-- * Standard SQL generation                   
-- *--------------------------------------------
-- * DB-MAIN version: 11.0.1              
-- * Generator date: Dec  4 2018              
-- * Generation date: Sun Jun 20 15:06:44 2021 
-- * LUN file: C:\Users\Luigi\Desktop\Uni\2° Anno\Basi di Dati\progetto\progettoBasiDiDati\DB-Main\Progetto.lun 
-- * Schema: Covid-19 Vaccine Tracker/SQL 
-- ********************************************* 


-- Database Section
-- ________________ 

create database Covid19VaccineTracker;
use Covid19VaccineTracker;


-- DBSpace Section
-- _______________


-- Tables Section
-- _____________ 

create table DOSI (
     IdVaccino int not null,
     IdOspedale int not null,
     TotDosi int not null,
     constraint ID_DOSI_ID primary key (IdVaccino, IdOspedale));

create table FORNITORE (
     IdFornitore int not null AUTO_INCREMENT,
     NomeFornitore char(20) not null,
     Telefono varchar(15) not null,
     IdVaccino int not null,
     constraint ID_FORNITORE_ID primary key (IdFornitore));

create table OSPEDALE (
     IdOspedale int not null AUTO_INCREMENT,
     Nome char(40) not null,
     Indirizzo char(30) not null,
     Telefono varchar(15) not null,
     constraint ID_OSPEDALE_ID primary key (IdOspedale));

create table PATOLOGIA (
     IdPatologia int not null AUTO_INCREMENT,
     NomePatologia char(20) not null,
     Descrizione char(50) not null,
     constraint ID_PATOLOGIA_ID primary key (IdPatologia));

create table PAZIENTE (
     IdPaziente int not null AUTO_INCREMENT,
     Nome char(20) not null,
     Cognome char(20) not null,
     DataNascita date not null,
     Sesso char(1) not null,
     CodFiscale varchar(16) not null,
     Telefono varchar(15) not null,
     Mail varchar(30) not null,
     IdResidenza int not null,
     IdVaccino int not null,
     IdPatologia int,
     IdOspedale int not null,
     constraint ID_PAZIENTE_ID primary key (IdPaziente));

create table INFERMIERE (
     IdInfermiere int not null AUTO_INCREMENT,
     Nome char(20) not null,
     Cognome char(20) not null,
     DataNascita date not null,
     Sesso char(1) not null,
     CodFiscale varchar(16) not null,
     Telefono varchar(15) not null,
     Mail varchar(30) not null,
     DataAssunzione date not null,
     IdOspedale int not null,
     constraint ID_INFERMIERE_ID primary key (IdInfermiere));

create table RESIDENZA (
     IdResidenza int not null AUTO_INCREMENT,
     Citta char(20) not null,
     Provincia char(20) not null,
     CAP int not null,
     TotaleVaccinati int not null,
     constraint ID_RESIDENZA_ID primary key (IdResidenza));

create table VACCINAZIONE (
     DataEffettuazione date not null,
     nRichiamo int not null,
     DataRichiamo date not null,
     IdPaziente int not null,
     IdInfermiere int not null,
     constraint ID_VACCINAZIONE_ID primary key (DataEffettuazione));

create table VACCINO (
     IdVaccino int not null AUTO_INCREMENT,
     Nome char(15) not null,
     CasaFarmaceutica char(20) not null,
     Richiamo int(3) not null,
     Info char(50) not null,
     PrezzoUnitario int(5) not null,
     constraint ID_VACCINO_ID primary key (IdVaccino));


-- Constraints Section
-- ___________________ 

alter table DOSI add constraint REF_DOSI_OSPED_FK
     foreign key (IdOspedale)
     references OSPEDALE(IdOspedale);

alter table DOSI add constraint REF_DOSI_VACCI
     foreign key (IdVaccino)
     references VACCINO(IdVaccino);

alter table FORNITORE add constraint REF_FORNI_VACCI_FK
     foreign key (IdVaccino)
     references VACCINO(IdVaccino);

alter table PAZIENTE add constraint REF_PAZIE_RESID_FK
     foreign key (IdResidenza)
     references RESIDENZA(IdResidenza);

alter table PAZIENTE add constraint REF_PAZIE_VACCI_FK
     foreign key (IdVaccino)
     references VACCINO(IdVaccino);

alter table PAZIENTE add constraint REF_PAZIE_PATOL_FK
     foreign key (IdPatologia)
     references PATOLOGIA(IdPatologia);

alter table PAZIENTE add constraint REF_PAZIE_OSPED_FK
     foreign key (IdOspedale)
     references OSPEDALE(IdOspedale);

alter table INFERMIERE add constraint REF_INFER_OSPED_FK
     foreign key (IdOspedale)
     references OSPEDALE(IdOspedale);

alter table VACCINAZIONE add constraint REF_VACCI_PAZIE_FK
     foreign key (IdPaziente)
     references PAZIENTE(IdPaziente);

alter table VACCINAZIONE add constraint REF_VACCI_INFER_FK
     foreign key (IdInfermiere)
     references INFERMIERE(IdInfermiere);


-- Index Section
-- _____________ 

create unique index ID_DOSI_IND
     on DOSI (IdVaccino, IdOspedale);

create index REF_DOSI_OSPED_IND
     on DOSI (IdOspedale);

create unique index ID_FORNITORE_IND
     on FORNITORE (IdFornitore);

create index REF_FORNI_VACCI_IND
     on FORNITORE (IdVaccino);

create unique index ID_OSPEDALE_IND
     on OSPEDALE (IdOspedale);

create unique index ID_PATOLOGIA_IND
     on PATOLOGIA (IdPatologia);

create unique index ID_PAZIENTE_IND
     on PAZIENTE (IdPaziente);

create index REF_PAZIE_RESID_IND
     on PAZIENTE (IdResidenza);

create index REF_PAZIE_VACCI_IND
     on PAZIENTE (IdVaccino);

create index REF_PAZIE_PATOL_IND
     on PAZIENTE (IdPatologia);

create index REF_PAZIE_OSPED_IND
     on PAZIENTE (IdOspedale);

create unique index ID_INFERMIERE_IND
     on INFERMIERE (IdInfermiere);

create index REF_INFER_OSPED_IND
     on INFERMIERE (IdOspedale);

create unique index ID_RESIDENZA_IND
     on RESIDENZA (IdResidenza);

create unique index ID_VACCINAZIONE_IND
     on VACCINAZIONE (DataEffettuazione);

create index REF_VACCI_PAZIE_IND
     on VACCINAZIONE (IdPaziente);

create index REF_VACCI_INFER_IND
     on VACCINAZIONE (IdInfermiere);

create unique index ID_VACCINO_IND
     on VACCINO (IdVaccino);

