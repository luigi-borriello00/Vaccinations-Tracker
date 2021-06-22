/* Vaccinazioni Effettuate in un giorno */
select V.*, P.Nome as "Nome Paziente", P.Cognome  as "Nome Paziente", I.Nome as "Nome Infermiere", I.Cognome as "Cognome Infermiere"  
from vaccinazione V join paziente P on P.IdPaziente = V.IdPaziente join infermiere I on I.IdInfermiere = V.IdInfermiere
where V.DataEffettuazione = "2021-05-10";

/* Pazienti vaccinati */
select P.* 
from vaccinazione V join paziente P on V.IdPaziente = P.IdPaziente;

/* Numero vaccinati per ogni residenza */
select * from residenza;

/* Aumento totVaccinati città con Id = 5 */
update residenza
set TotaleVaccinati = TotaleVaccinati + 1
where IdResidenza = 5;

update dosi
set TotDosi = TotDosi - 1
where IdVaccino = 5;

/* Visualizzazione vaccinati per ogni infermiere */
select P.*
from infermiere I join vaccinazione V on I.IdInfermiere = V.IdInfermiere join paziente P on P.IdPaziente = V.IdPaziente
where I.IdInfermiere = 6;

/* Visualizzazione pazienti malati di "tumore" */
select count(*) as "Numero pazienti malati"
from paziente where paziente.IdPatologia = 3;

/* Infermieri che ha eseguito piu vaccinazioni */
select count(*) as "Vaccinazioni effettuate", I.Nome, I.Cognome
from infermiere I join vaccinazione V on I.IdInfermiere = V.IdInfermiere
group by I.Nome
order by count(*) desc, I.Cognome;

/* Infermieri che hanno effettuato piu di 1 vacc */
select count(*) as "Vaccinazioni effettuate", I.Nome, I.Cognome
from infermiere I join vaccinazione V on I.IdInfermiere = V.IdInfermiere
group by I.Nome
having count(*) > 1;

/* Vaccinazioni vaccino per vaccino */
select count(*) as "N° vaccini effettuati", VC.Nome as "Vaccino"
from vaccinazione V join paziente P on V.IdPaziente = P.IdPaziente join vaccino VC on VC.IdVaccino = P.IdVaccino
group by VC.Nome;



