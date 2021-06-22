/* VACCINI */
insert into vaccino(Nome, CasaFarmaceutica, Richiamo, Info, PrezzoUnitario)
values ("Pfizer", "Pfizer-BioNTech", 21, "mRNA", 15), ("Moderna", "Moderna", 28, "mRNA", 14), ("Astrazeneca", "Astrazeneca", 63, "Vettore virale", 2);

/* RESIDENZA */
insert into residenza(Citta, Provincia, CAP, TotaleVaccinati)
values ("Cesena", "FC", 47521, 0), ("Cesenatico", "FC", 47042, 0), ("Forlì", "FC", 47121, 0), ("Rimini", "RN", 47921, 0), ("Riccione", "RN", 47838, 0), ("Forlimpopoli", "FC", 47034, 0);

/* OSPEDALE */
insert into ospedale(Nome, Indirizzo, Telefono)
values ("Ospedale 'M. Bufalini' di Cesena", "Viale Giovanni Ghirotti, 286", "0547352111");

/* PATOLOGIA */
insert into patologia(NomePatologia, Descrizione)
values("Diabete", "Aumento nel sangue dei livelli di glucosio."),("Asma", "Infiammazione diffusa delle vie aeree."), ("Tumore", "Proliferazione di cellule tumorali."),
("Cardiopatia", "Qualsiasi malattia che interessi il cuore."); 

/* FORNITORE */
insert into fornitore(NomeFornitore, Telefono, IdVaccino)
values("Franceschetti Corp.", "0717980496", 1), ("Borriello S.p.A", "07160279", 2), ("Orlietti S.p.A.", "07179112", 3);

/* INFERMIERE */
insert into covid19vaccinetracker.infermiere(Nome, Cognome, DataNascita, Sesso, CodFiscale, Telefono, Mail, DataAssunzione, IdOspedale)
values("Emanuele", "Orlietti", '1996-08-08', "M", "RLTMNL96M08I608A", "3398453208", "e.orlietti@gmail.com", "2019-01-05", 1);
insert into covid19vaccinetracker.infermiere(Nome, Cognome, DataNascita, Sesso, CodFiscale, Telefono, Mail, DataAssunzione, IdOspedale)
values("Luigi", "Borriello", '2000-05-15', "M", "BRRLGU00E15I608H", "3667154519", "l.borriello@gmail.com", "2018-01-10", 1);
insert into covid19vaccinetracker.infermiere(Nome, Cognome, DataNascita, Sesso, CodFiscale, Telefono, Mail, DataAssunzione, IdOspedale)
values("Mario", "Rossi", '1990-06-06', "M", "MRARSS90H06I608W", "3336667771", "m.rossi@gmail.com", "2010-12-30", 1);
insert into covid19vaccinetracker.infermiere(Nome, Cognome, DataNascita, Sesso, CodFiscale, Telefono, Mail, DataAssunzione, IdOspedale)
values("Francesca", "Bianchi", '1988-12-10', "F", "FRNBCH88T10A271O", "3456789123", "f.bianchi@gmail.com", "2015-11-14", 1);
insert into covid19vaccinetracker.infermiere(Nome, Cognome, DataNascita, Sesso, CodFiscale, Telefono, Mail, DataAssunzione, IdOspedale)
values("Giulia", "Orlietti", '1980-04-08', "F", "RLTGLI80D48G479N", "3210987654", "g.orlietti@gmail.com", "2008-05-12", 1);
insert into covid19vaccinetracker.infermiere(Nome, Cognome, DataNascita, Sesso, CodFiscale, Telefono, Mail, DataAssunzione, IdOspedale)
values("Luca", "Assanti", '2000-11-03', "M", "SSNLCU00S11I608M", "3678902341", "l.assanti@gmail.com", "2021-01-14", 1);

/* PAZIENTE */
insert into covid19vaccinetracker.paziente(Nome, Cognome, DataNascita, Sesso, CodFiscale, Telefono, Mail, IdResidenza, IdVaccino, IdPatologia, IdOspedale)
values("Mario", "Draghi", '2000-05-31', "M", "DRGMRA00E31H501O", "3563563561", "m.draghi@gmail.com", 1, 1, 1, 1);
insert into covid19vaccinetracker.paziente(Nome, Cognome, DataNascita, Sesso, CodFiscale, Telefono, Mail, IdResidenza, IdVaccino, IdOspedale)
values("Giovanni", "D'arco", '1998-03-10', "M", "GVNDRC88C10I608P", "3563523561", "g.darco@gmail.com", 2, 1, 1);
insert into covid19vaccinetracker.paziente(Nome, Cognome, DataNascita, Sesso, CodFiscale, Telefono, Mail, IdResidenza, IdVaccino, IdPatologia, IdOspedale)
values("Brando", "Pitto", '1955-06-27', "M", "BRNPTT77H27F205M", "3233563561", "b.pitto@gmail.com", 3, 3, 2, 1);
insert into covid19vaccinetracker.paziente(Nome, Cognome, DataNascita, Sesso, CodFiscale, Telefono, Mail, IdResidenza, IdVaccino, IdOspedale)
values("Tommaso", "Benedetti", '1999-12-08', "M", "TMMBDT99T08I608U", "3563567761", "t.benedetti@gmail.com", 2, 2, 1);
insert into covid19vaccinetracker.paziente(Nome, Cognome, DataNascita, Sesso, CodFiscale, Telefono, Mail, IdResidenza, IdVaccino, IdPatologia, IdOspedale)
values("Alice", "Orciari", '2002-09-15', "F", "LCARCR02P55A271E", "3443443449", "a.orciari@gmail.com", 4, 3, 3, 1);
insert into covid19vaccinetracker.paziente(Nome, Cognome, DataNascita, Sesso, CodFiscale, Telefono, Mail, IdResidenza, IdVaccino, IdOspedale)
values("Giulia", "Franceschi", '1999-08-01', "F", "GLIFNC99M01I608G", "3563566661", "g.franceschi@gmail.com", 6, 2, 1);
insert into covid19vaccinetracker.paziente(Nome, Cognome, DataNascita, Sesso, CodFiscale, Telefono, Mail, IdResidenza, IdVaccino, IdOspedale)
values("Carla", "Bruni", '1950-01-01', "F", "CRLBRN50A41I608E", "3713567761", "c.bruni@gmail.com", 5, 3, 1);
insert into covid19vaccinetracker.paziente(Nome, Cognome, DataNascita, Sesso, CodFiscale, Telefono, Mail, IdResidenza, IdVaccino, IdPatologia, IdOspedale)
values("Ludovica", "Carletti", '2003-03-10', "F", "LDVCLT03C50A271R", "3447775449", "l.carletti@gmail.com", 4, 2, 4, 1);
insert into covid19vaccinetracker.paziente(Nome, Cognome, DataNascita, Sesso, CodFiscale, Telefono, Mail, IdResidenza, IdVaccino, IdOspedale)
values("Giacomo", "Poretti", '1966-06-12', "M", "GCMPTT66H12I608N", "3563888661", "g.poretti@gmail.com", 3, 3, 1);
insert into covid19vaccinetracker.paziente(Nome, Cognome, DataNascita, Sesso, CodFiscale, Telefono, Mail, IdResidenza, IdVaccino, IdOspedale)
values("Aldo", "Baio", '1966-06-13', "M", "BGLLDA66H13I608M", "3713713718", "a.baio@gmail.com", 3, 3, 1);

/* DOSI */
insert into covid19vaccinetracker.dosi(IdVaccino, IdOspedale, TotDosi)
values(1, 1, 1000);
insert into covid19vaccinetracker.dosi(IdVaccino, IdOspedale, TotDosi)
values(2, 1, 1000);
insert into covid19vaccinetracker.dosi(IdVaccino, IdOspedale, TotDosi)
values(3, 1, 1000);

/* VACCINAZIONI */
insert into covid19vaccinetracker.vaccinazione(DataEffettuazione, nRichiamo, DataRichiamo, IdPaziente, IdInfermiere)
values("2021-06-22", 1, "2021-07-13", 1, 1);

insert into covid19vaccinetracker.vaccinazione(DataEffettuazione, nRichiamo, DataRichiamo, IdPaziente, IdInfermiere)
values("2021-06-18", 1, "2021-07-9", 2, 2);

insert into covid19vaccinetracker.vaccinazione(DataEffettuazione, nRichiamo, DataRichiamo, IdPaziente, IdInfermiere)
values("2021-05-10", 1, "2021-07-12", 3, 3);

insert into covid19vaccinetracker.vaccinazione(DataEffettuazione, nRichiamo, DataRichiamo, IdPaziente, IdInfermiere)
values("2021-05-15", 1, "2021-06-12", 4, 4);

insert into covid19vaccinetracker.vaccinazione(DataEffettuazione, nRichiamo, DataRichiamo, IdPaziente, IdInfermiere)
values("2021-05-03", 1, "2021-07-05", 5, 5);

insert into covid19vaccinetracker.vaccinazione(DataEffettuazione, nRichiamo, DataRichiamo, IdPaziente, IdInfermiere)
values("2021-04-21", 1, "2021-05-19", 6, 6);

insert into covid19vaccinetracker.vaccinazione(DataEffettuazione, nRichiamo, DataRichiamo, IdPaziente, IdInfermiere)
values("2021-05-10", 1, "2021-07-12", 7, 1);

insert into covid19vaccinetracker.vaccinazione(DataEffettuazione, nRichiamo, DataRichiamo, IdPaziente, IdInfermiere)
values("2021-06-11", 1, "2021-07-09", 8, 2);

insert into covid19vaccinetracker.vaccinazione(DataEffettuazione, nRichiamo, DataRichiamo, IdPaziente, IdInfermiere)
values("2021-05-08", 1, "2021-07-10", 9, 3);

insert into covid19vaccinetracker.vaccinazione(DataEffettuazione, nRichiamo, DataRichiamo, IdPaziente, IdInfermiere)
values("2021-05-09", 1, "2021-07-11", 10, 4);




