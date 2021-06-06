-- *********************************************
-- * Standard SQL generation                   
-- *--------------------------------------------
-- * DB-MAIN version: 11.0.1              
-- * Generator date: Dec  4 2018              
-- * Generation date: Sun Jun  6 15:57:17 2021 
-- * LUN file: C:\Users\Luigi\Desktop\Uni\2° Anno\Basi di Dati\progetto\progettoBasiDiDati\DB-Main\Progetto.lun 
-- * Schema: Covid-19 Vaccine Tracker/SQL 
-- ********************************************* 


-- Database Section
-- ________________ 

create database Covid-19 Vaccine Tracker;


-- DBSpace Section
-- _______________


-- Tables Section
-- _____________ 

create table DOSI (
     IdVaccino -- Index attribute not implemented -- not null,
     IdOspedale -- Index attribute not implemented -- not null,
     TotDosi numeric(10) not null,
     constraint ID_DOSI_ID primary key (IdVaccino, IdOspedale));

create table FORNITORE (
     IdFornitore -- Index attribute not implemented -- not null,
     NomeFornitore char(20) not null,
     Telefono numeric(10) not null,
     IdVaccino -- Index attribute not implemented -- not null,
     constraint ID_FORNITORE_ID primary key (IdFornitore));

create table OSPEDALE (
     IdOspedale -- Index attribute not implemented -- not null,
     Nome char(15) not null,
     Indirizzo char(30) not null,
     Telefono numeric(10) not null,
     IdDirettore -- Index attribute not implemented -- not null,
     constraint ID_OSPEDALE_ID primary key (IdOspedale));

create table PATOLOGIA (
     IdPatologia -- Index attribute not implemented -- not null,
     NomePatologia char(20) not null,
     Descrizione char(30) not null,
     constraint ID_PATOLOGIA_ID primary key (IdPatologia));

create table PAZIENTE (
     ID_PAZ -- Sequence attribute not implemented -- not null,
     IdPaziente -- Index attribute not implemented -- not null,
     Nome char(15) not null,
     Cognome char(15) not null,
     DataNascita date not null,
     Sesso char(1) not null,
     CodFiscale varchar(16) not null,
     Telefono numeric(10) not null,
     Mail varchar(30) not null,
     IdResidenza -- Index attribute not implemented -- not null,
     IdVaccino -- Index attribute not implemented -- not null,
     IdPatologia -- Index attribute not implemented --,
     IdOspedale -- Index attribute not implemented -- not null,
     constraint ID_PAZIENTE_ID primary key (ID_PAZ),
     constraint SID_PAZIENTE_ID unique (IdPaziente));

create table INFERMIERE (
     ID_INF -- Sequence attribute not implemented -- not null,
     IdInfermiere -- Index attribute not implemented -- not null,
     Nome char(15) not null,
     Cognome char(15) not null,
     DataNascita date not null,
     Sesso char(1) not null,
     CodFiscale varchar(16) not null,
     Telefono numeric(10) not null,
     Mail varchar(30) not null,
     DataAssunzione date not null,
     IdOspedale -- Index attribute not implemented -- not null,
     constraint ID_INFERMIERE_ID primary key (ID_INF),
     constraint SID_INFERMIERE_ID unique (IdInfermiere));

create table RESIDENZA (
     IdResidenza -- Index attribute not implemented -- not null,
     Citta char(20) not null,
     Provincia char(20) not null,
     CAP numeric(8) not null,
     TotaleVaccinati numeric(10) not null,
     constraint ID_RESIDENZA_ID primary key (IdResidenza));

create table VACCINAZIONE (
     DataEffettuazione date not null,
     nRichiamo numeric(1) not null,
     DataRichiamo date not null,
     ID_PAZ numeric(10) not null,
     ID_INF numeric(10) not null,
     constraint ID_VACCINAZIONE_ID primary key (DataEffettuazione));

create table VACCINO (
     IdVaccino -- Index attribute not implemented -- not null,
     Nome char(15) not null,
     CasaFarmaceutica char(20) not null,
     Richiamo numeric(3) not null,
     Info char(50) not null,
     PrezzoUnitario numeric(5) not null,
     constraint ID_VACCINO_ID primary key (IdVaccino));


-- Constraints Section
-- ___________________ 

alter table DOSI add constraint REF_DOSI_OSPED_FK
     foreign key (IdOspedale)
     references OSPEDALE;

alter table DOSI add constraint REF_DOSI_VACCI
     foreign key (IdVaccino)
     references VACCINO;

alter table FORNITORE add constraint REF_FORNI_VACCI_FK
     foreign key (IdVaccino)
     references VACCINO;

alter table PAZIENTE add constraint ID_PAZIENTE_CHK
     check(exists(select * from VACCINAZIONE
                  where VACCINAZIONE.ID_PAZ = ID_PAZ)); 

alter table PAZIENTE add constraint REF_PAZIE_RESID_FK
     foreign key (IdResidenza)
     references RESIDENZA;

alter table PAZIENTE add constraint REF_PAZIE_VACCI_FK
     foreign key (IdVaccino)
     references VACCINO;

alter table PAZIENTE add constraint REF_PAZIE_PATOL_FK
     foreign key (IdPatologia)
     references PATOLOGIA;

alter table PAZIENTE add constraint REF_PAZIE_OSPED_FK
     foreign key (IdOspedale)
     references OSPEDALE;

alter table INFERMIERE add constraint REF_INFER_OSPED_FK
     foreign key (IdOspedale)
     references OSPEDALE;

alter table VACCINAZIONE add constraint EQU_VACCI_PAZIE_FK
     foreign key (ID_PAZ)
     references PAZIENTE;

alter table VACCINAZIONE add constraint REF_VACCI_INFER_FK
     foreign key (ID_INF)
     references INFERMIERE;


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
     on PAZIENTE (ID_PAZ);

create unique index SID_PAZIENTE_IND
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
     on INFERMIERE (ID_INF);

create unique index SID_INFERMIERE_IND
     on INFERMIERE (IdInfermiere);

create index REF_INFER_OSPED_IND
     on INFERMIERE (IdOspedale);

create unique index ID_RESIDENZA_IND
     on RESIDENZA (IdResidenza);

create unique index ID_VACCINAZIONE_IND
     on VACCINAZIONE (DataEffettuazione);

create index EQU_VACCI_PAZIE_IND
     on VACCINAZIONE (ID_PAZ);

create index REF_VACCI_INFER_IND
     on VACCINAZIONE (ID_INF);

create unique index ID_VACCINO_IND
     on VACCINO (IdVaccino);

