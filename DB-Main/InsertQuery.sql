insert into vaccino(Nome, CasaFarmaceutica, Richiamo, Info, PrezzoUnitario)
values ("Pfizer", "Pfizer-BioNTech", 21, "mRNA", 15), ("Moderna", "Moderna", 28, "mRNA", 14), ("Astrazeneca", "Astrazeneca", 63, "Vettore virale", 2);

insert into residenza(Citta, Provincia, CAP, TotaleVaccinati)
values ("Cesena", "FC", 47521, 0), ("Cesenatico", "FC", 47042, 0), ("Forlì", "FC", 47121, 0), ("Rimini", "RN", 47921, 0), ("Riccione", "RN", 47838, 0), ("Forlimpopoli", "FC", 47034, 0);

insert into ospedale(Nome, Indirizzo, Telefono)
values ("Ospedale 'M. Bufalini' di Cesena", "Viale Giovanni Ghirotti, 286", "0547352111");

insert into patologia(NomePatologia, Descrizione)
values("Diabete", "Aumento nel sangue dei livelli di glucosio."),("Asma", "Infiammazione diffusa delle vie aeree."), ("Tumore", "Proliferazione di cellule tumorali."),
("Cardiopatia", "Qualsiasi malattia che interessi il cuore."); 

insert into fornitore(NomeFornitore, Telefono, IdVaccino)
values("Franceschetti Corp.", "0717980496", 1), ("Borriello S.p.A", "07160279", 2), ("Orlietti S.p.A.", "07179112", 3);