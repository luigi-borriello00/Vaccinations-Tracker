-- *********************************************
-- * Standard SQL generation                   
-- *--------------------------------------------
-- * DB-MAIN version: 11.0.1              
-- * Generator date: Dec  4 2018              
-- * Generation date: Sat Jun  5 15:40:21 2021 
-- * LUN file: C:\Users\eorli\OneDrive\Desktop\Università\Corsi\Basi di dati\progettoBasiDiDati\DB-Main\Progetto.lun 
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
     IdVaccino int not null,
     IdOspedale int not null,
     IdDosi int not null,
     TotDosi numeric(10) not null,
     constraint ID_DOSI_ID primary key (IdVaccino, IdOspedale, IdDosi));

create table FORNITORE (
     IdFornitore int not null,
     NomeFornitore varchar(20) not null,
     Telefono numeric(10) not null,
     IdVaccino int not null,
     constraint ID_FORNITORE_ID primary key (IdFornitore));

create table OSPEDALE (
     IdOspedale int not null,
     Nome varchar(15) not null,
     Indirizzo varchar(30) not null,
     Telefono numeric(10) not null,
     IdDirettore varchar(4) not null,
     constraint ID_OSPEDALE_ID primary key (IdOspedale));

create table PATOLOGIA (
     IdPatologia int not null,
     NomePatologia varchar(20) not null,
     Descrizione varchar(30) not null,
     constraint ID_PATOLOGIA_ID primary key (IdPatologia));

create table INFERMIERE (
     ID_INF -- Sequence attribute not implemented -- not null,
     IdInfermiere int not null,
     Nome varchar(15) not null,
     Cognome varchar(15) not null,
     DataNascita date not null,
     Sesso char(1) not null,
     CodFiscale char(16) not null,
     Telefono numeric(10) not null,
     Mail varchar(30) not null,
     DataAssunzione date not null,
     IdOspedale int not null,
     constraint ID_INFERMIERE_ID primary key (ID_INF),
     constraint SID_INFERMIERE_ID unique (IdInfermiere));

create table PAZIENTE (
     ID_PAZ -- Sequence attribute not implemented -- not null,
     IdPaziente int not null,
     Nome char(15) not null,
     Cognome char(15) not null,
     DataNascita date not null,
     Sesso char(1) not null,
     CodFiscale char(16) not null,
     Telefono numeric(10) not null,
     Mail varchar(30) not null,
     IdResidenza int not null,
     IdPatologia numeric(1) not null,
     RIS_IdResidenza int not null,
     IdOspedale int not null,
     POS_IdPatologia int,
     constraint ID_PAZIENTE_ID primary key (ID_PAZ),
     constraint SID_PAZIENTE_ID unique (IdPaziente));

create table RESIDENZA (
     IdResidenza int not null,
     Citta varchar(20) not null,
     Provincia varchar(20) not null,
     CAP numeric(8) not null,
     TotaleVaccinati numeric(10) not null,
     constraint ID_RESIDENZA_ID primary key (IdResidenza));

create table VACCINAZIONE (
     ID_INF numeric(10) not null,
     ID_PAZ numeric(10) not null,
     IdVaccino int not null,
     IdVaccinazione int not null,
     DataEffettuazione date not null,
     nRichiamo numeric(1) not null,
     DataRichiamo date not null,
     constraint ID_VACCINAZIONE_ID primary key (IdVaccino, ID_INF, ID_PAZ, IdVaccinazione));

create table VACCINO (
     IdVaccino int not null,
     Nome varchar(15) not null,
     CasaFarmaceutica varchar(20) not null,
     Richiamo numeric(3) not null,
     Info varchar(50) not null,
     PrezzoUnitario numeric(5) not null,
     IdFornitore int not null,
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

alter table INFERMIERE add constraint REF_INFER_OSPED_FK
     foreign key (IdOspedale)
     references OSPEDALE;

alter table PAZIENTE add constraint ID_PAZIENTE_CHK
     check(exists(select * from VACCINAZIONE
                  where VACCINAZIONE.ID_PAZ = ID_PAZ)); 

alter table PAZIENTE add constraint REF_PAZIE_RESID_FK
     foreign key (RIS_IdResidenza)
     references RESIDENZA;

alter table PAZIENTE add constraint REF_PAZIE_OSPED_FK
     foreign key (IdOspedale)
     references OSPEDALE;

alter table PAZIENTE add constraint REF_PAZIE_PATOL_FK
     foreign key (POS_IdPatologia)
     references PATOLOGIA;

alter table VACCINAZIONE add constraint REF_VACCI_VACCI
     foreign key (IdVaccino)
     references VACCINO;

alter table VACCINAZIONE add constraint EQU_VACCI_PAZIE_FK
     foreign key (ID_PAZ)
     references PAZIENTE;

alter table VACCINAZIONE add constraint REF_VACCI_INFER_FK
     foreign key (ID_INF)
     references INFERMIERE;


-- Index Section
-- _____________ 

create unique index ID_DOSI_IND
     on DOSI (IdVaccino, IdOspedale, IdDosi);

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

create unique index ID_INFERMIERE_IND
     on INFERMIERE (ID_INF);

create unique index SID_INFERMIERE_IND
     on INFERMIERE (IdInfermiere);

create index REF_INFER_OSPED_IND
     on INFERMIERE (IdOspedale);

create unique index ID_PAZIENTE_IND
     on PAZIENTE (ID_PAZ);

create unique index SID_PAZIENTE_IND
     on PAZIENTE (IdPaziente);

create index REF_PAZIE_RESID_IND
     on PAZIENTE (RIS_IdResidenza);

create index REF_PAZIE_OSPED_IND
     on PAZIENTE (IdOspedale);

create index REF_PAZIE_PATOL_IND
     on PAZIENTE (POS_IdPatologia);

create unique index ID_RESIDENZA_IND
     on RESIDENZA (IdResidenza);

create unique index ID_VACCINAZIONE_IND
     on VACCINAZIONE (IdVaccino, ID_INF, ID_PAZ, IdVaccinazione);

create index EQU_VACCI_PAZIE_IND
     on VACCINAZIONE (ID_PAZ);

create index REF_VACCI_INFER_IND
     on VACCINAZIONE (ID_INF);

create unique index ID_VACCINO_IND
     on VACCINO (IdVaccino);

