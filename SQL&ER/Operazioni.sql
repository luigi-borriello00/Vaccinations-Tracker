/* Inserimento di una residenza */
insert into residenza(Citta, Provincia, CAP, TotaleVaccinati)
values (?, ?, ?, ?)

/* Inserimento di una Vaccinazione */
insert into vaccinazione(DataEffettuazione, nRichiamo, DataRichiamo, IdPaziente, IdInfermiere)
values(?,?,?,?,?);
// -1 dose dal magazzino
// +1 in NumVaccinati -> Residenza

/* Inserimento di un paziente */
insert into paziente(Nome, Cognome, DataNascita, Sesso, CodFiscale, Telefono, Mail, IdResidenza, IdVaccino, IdPatologia, IdOspedale)
values(?,?,?,?,?,?,?,?,?,?,?);

/* Inserimento di una patologia */
insert into patologia(NomePatologia, Descrizione)
values(?,?)

/* Visualizzazione vaccinati per ogni infermiere */
select P.*
from infermiere I join vaccinazione V on I.IdInfermiere = V.IdInfermiere join paziente P on P.IdPaziente = V.IdPaziente
where I.IdInfermiere = ?;

/* Visualizzazione vaccinazioni per un paziente */
select P.*, Va.Nome as "Nome Vaccino", PA.NomePatologia as "Patologia"
from infermiere I 
join vaccinazione V on I.IdInfermiere = V.IdInfermiere 
join paziente P on P.IdPaziente = V.IdPaziente
left join patologia PA on PA.IdPatologia = P.IdPatologia
join vaccino VA on VA.IdVaccino = P.IdVaccino
where P.IdPaziente = ?;


// DIRETTORE
/* Vaccinazioni Effettuate in un giorno */
select V.*, P.Nome as "Nome Paziente", P.Cognome  as "Nome Paziente", I.Nome as "Nome Infermiere", I.Cognome as "Cognome Infermiere"  
from vaccinazione V 
join paziente P on P.IdPaziente = V.IdPaziente 
join infermiere I on I.IdInfermiere = V.IdInfermiere
where V.DataEffettuazione = ?;

/* Inserimento infermiere */
insert into infermiere(Nome, Cognome, DataNascita, Sesso, CodFiscale, Telefono, Mail, DataAssunzione, IdOspedale)
values(?,?,?,?,?,?,?,?,?);

/* N vaccinati per ogni città */
/* Numero vaccinati per ogni residenza */
select * 
from residenza;

/* Top 10 Infermieri con piu vaccinazioni */
SELECT TOP (5) Inf.IdInfermiere, Inf.Nome,Inf.Cognome, Inf.Telefono, Inf.CodFiscale, Inf.DataNascita, Inf.Sesso,
Inf.DataAssunzione, Inf.Mail, count(*) as "Numero Vaccinazioni effettuate"
from infermiere Inf, vaccinazione V 
where Inf.IdInfermiere = V.IdInfermiere
group by Inf.IdInfermiere, Inf.Nome,Inf.Cognome, Inf.Telefono, Inf.CodFiscale, Inf.DataNascita, Inf.Sesso,
Inf.DataAssunzione, Inf.Mail
order by count(*) desc

/* Infermiere che ha eseguito piu vaccinazioni in un mese */
select count(*) as "Vaccinazioni effettuate", I.Nome, I.Cognome, I.CodFiscale, I.DataNascita, I.DataAssunzione, I.Telefono, I.Mail, I.Sesso
from infermiere I join vaccinazione V on I.IdInfermiere = V.IdInfermiere
where month(V.DataEffettuazione) = month(?)
group by I.Nome, I.Cognome, I.CodFiscale, I.DataNascita, I.DataAssunzione, I.Telefono, I.Mail, I.Sesso
order by count(*) desc, I.Cognome;

/* Infermieri che hanno effettuato piu di ? vacc */
select count(*) as "Vaccinazioni effettuate", I.Nome, I.Cognome
from infermiere I 
join vaccinazione V on I.IdInfermiere = V.IdInfermiere
group by I.Nome
having count(*) > ?;

/* Vaccinazioni vaccino per vaccino mese per mese*/
select datename(month, V.DataEffettuazione) as "Mese", count(*) as "N° vaccini effettuati", VC.Nome as "Vaccino"
from vaccinazione V 
join paziente P on V.IdPaziente = P.IdPaziente 
join vaccino VC on VC.IdVaccino = P.IdVaccino
group by datename(month, V.DataEffettuazione), VC.Nome
order by datename(month, V.DataEffettuazione), Vc.Nome;

/* Infermieri vaccinanti in una data */
select *
from covid19vaccinetracker.infermiere I
where I.IdInfermiere in (select INF.IdInfermiere
						from covid19vaccinetracker.infermiere INF, covid19vaccinetracker.vaccinazione V
						where INF.IdInfermiere = V.IdInfermiere
						and V.DataEffettuazione = '2021-06-29')

/* Visualizzazione scorte magazzino */
select D.TotDosi, V.* as "Nome Vaccino"
from dosi D join vaccino V on D.IdVaccino = V.IdVaccino;

/* Visualizzazione info fornitori */
select F.*, V.Nome as "NomeVaccino"
from fornitore F join vaccino V on F.IdVaccino = V.IdVaccino
order by V.Nome;

/* Inserimento nuove scorte */
update dosi
set TotDosi = TotDosi + ?
where IdVaccino = ?;

/* Nuovo fornitore */
insert into fornitore(NomeFornitore, Telefono, IdVaccino)
values(?,?,?)

/* nuovo vaccino */
insert into vaccino(Nome, CasaFarmaceutica, Richiamo, Info, PrezzoUnitario)
values (?,?,?,?,?)





/* Aumento totVaccinati città con Id = ? */
update residenza
set TotaleVaccinati = TotaleVaccinati + 1
where IdResidenza = ?;

/* Diminuizione dosi in magazzino */
update dosi
set TotDosi = TotDosi - 1
where IdVaccino = ?;





