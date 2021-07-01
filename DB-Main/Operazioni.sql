/* Vaccinazioni Effettuate in un giorno */
select V.*, P.Nome as "Nome Paziente", P.Cognome  as "Nome Paziente", I.Nome as "Nome Infermiere", I.Cognome as "Cognome Infermiere"  
from covid19vaccinetracker.vaccinazione V join covid19vaccinetracker.paziente P on P.IdPaziente = V.IdPaziente join covid19vaccinetracker.infermiere I on I.IdInfermiere = V.IdInfermiere
where V.DataEffettuazione = "2021-05-10";

/* Infermieri vaccinanti in una data */
select *
from covid19vaccinetracker.infermiere I
where I.IdInfermiere in (select INF.IdInfermiere
						from covid19vaccinetracker.infermiere INF, covid19vaccinetracker.vaccinazione V
						where INF.IdInfermiere = V.IdInfermiere
						and V.DataEffettuazione = '2021-06-29')


/* Pazienti vaccinati */
select P.* 
from covid19vaccinetracker.vaccinazione V join covid19vaccinetracker.paziente P on V.IdPaziente = P.IdPaziente;

/* Numero vaccinati per ogni residenza */
select * from covid19vaccinetracker.residenza;

/* Aumento totVaccinati città con Id = 5 */
update covid19vaccinetracker.residenza
set TotaleVaccinati = TotaleVaccinati + 1
where IdResidenza = 5;

update covid19vaccinetracker.dosi
set TotDosi = TotDosi - 1
where IdVaccino = 5;

/* Visualizzazione vaccinati per ogni infermiere */
select P.*
from covid19vaccinetracker.infermiere I join covid19vaccinetracker.vaccinazione V on I.IdInfermiere = V.IdInfermiere join covid19vaccinetracker.paziente P on P.IdPaziente = V.IdPaziente
where I.IdInfermiere = 6;

/* Visualizzazione pazienti malati di "tumore" */
select count(*) as "Numero pazienti malati"
from covid19vaccinetracker.paziente where paziente.IdPatologia = 3;

/* Infermiere che ha eseguito piu vaccinazioni */
select count(*) as "Vaccinazioni effettuate", I.Nome, I.Cognome, I.CodFiscale, I.DataNascita, I.DataAssunzione, I.Telefono, I.Mail, I.Sesso
from covid19vaccinetracker.infermiere I join covid19vaccinetracker.vaccinazione V on I.IdInfermiere = V.IdInfermiere
group by I.Nome, I.Cognome, I.CodFiscale, I.DataNascita, I.DataAssunzione, I.Telefono, I.Mail, I.Sesso
order by count(*) desc, I.Cognome;

/* Infermiere che ha eseguito piu vaccinazioni in un mese */
select count(*) as "Vaccinazioni effettuate", I.Nome, I.Cognome, I.CodFiscale, I.DataNascita, I.DataAssunzione, I.Telefono, I.Mail, I.Sesso
from covid19vaccinetracker.infermiere I join covid19vaccinetracker.vaccinazione V on I.IdInfermiere = V.IdInfermiere
where month(V.DataEffettuazione) = month('2021-04-01')
group by I.Nome, I.Cognome, I.CodFiscale, I.DataNascita, I.DataAssunzione, I.Telefono, I.Mail, I.Sesso
order by count(*) desc, I.Cognome;

/* Infermieri che hanno effettuato piu di 1 vacc */
select count(*) as "Vaccinazioni effettuate", I.Nome, I.Cognome
from covid19vaccinetracker.infermiere I join covid19vaccinetracker.vaccinazione V on I.IdInfermiere = V.IdInfermiere
group by I.Nome
having count(*) > 1;

/* Vaccinazioni vaccino per vaccino mese per mese*/
select datename(month, V.DataEffettuazione) as "Mese", count(*) as "N° vaccini effettuati", VC.Nome as "Vaccino"
from covid19vaccinetracker.vaccinazione V join covid19vaccinetracker.paziente P on V.IdPaziente = P.IdPaziente join covid19vaccinetracker.vaccino VC on VC.IdVaccino = P.IdVaccino
group by datename(month, V.DataEffettuazione), VC.Nome
order by datename(month, V.DataEffettuazione), Vc.Nome;

/* Visualizzazione scorte magazzino */
select D.TotDosi, V.* as "Nome Vaccino"
from covid19vaccinetracker.dosi D join covid19vaccinetracker.vaccino V on D.IdVaccino = V.IdVaccino;

/* Totale pazienti con una certa patologia */
select count(*) as "N° pazienti Malati"
from covid19vaccinetracker.paziente P join covid19vaccinetracker.patologia PA on P.IdPatologia = PA.IdPatologia
where PA.IdPatologia = 1;

/* Visualizzazione info fornitori */
select F.*, V.Nome as "NomeVaccino"
from covid19vaccinetracker.fornitore F join covid19vaccinetracker.vaccino V on F.IdVaccino = V.IdVaccino
order by V.Nome;

/* Infermiere con piu vaccinazioni */
select count(*) as "Numero vaccinazioni effettuate"
from covid19vaccinetracker.infermiere I join covid19vaccinetracker.vaccinazione V
on I.IdInfermiere = V.IdInfermiere
where I.IdOspedale = 1
group by I.Nome
order by count(*) desc



