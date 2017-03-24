# UnicamFattoriale
Questo programma chiede all'utente di digitare un numero per calcolare il suo [fattoriale](https://it.wikipedia.org/wiki/Fattoriale).

## Comportamento desiderato (specifica del programma)
 1. All'utente dev'essere chiesto di digitare un numero intero;
 2. Se l'utente non digita un numero intero o se digita un numero intero troppo grande, il programma non deve andare in errore ma deve mostrare il messaggio "Spiacente, non posso calcolare il fattoriale per questo valore";
 3. Se l'utente ha digitato un numero intero valido, allora il programma mostrerà il messaggio "Il fattoriale di `numero` è `risultato`", dove le parole "fattoriale" e "risultato" vanno ovviamente sostituite con i numeri in questione;
 4. Il risultato del calcolo fattoriale deve essere corretto;
 5. Per convenzione, il fattoriale di 0 è 1. Il programma deve gestire questo caso;
 6. *Nice-to-have*: dopo il calcolo, il programma non deve uscire ma chiedere all'utente di inserire un altro numero, finché non inserisce un testo non valido. *Nota: le funzionalità cosiddette "nice-to-have" NON sono essenziali al corretto funzionamento del programma ma migliorano l'esperienza di utilizzo dell'utente.*

 ## Email da Bob (il cliente) a proposito del funzionamento attuale del programma
Ciao,
senti, ho provato ad usare il programma ma ancora non va bene. Ti segnalo queste difformità dalla specifica che avevamo concordato insieme.
* Ho degli errori sia digitando un testo a caso che digitando un numero grande;
* Se digito un numero qualsiasi, il programma mi dice sempre "Il fattoriale di -1 è 0". Che roba è?
* Ogni volta che digito un numero, poi sono costretto a riaprire il programma per digitarne un altro ma... vabbé, avevamo detto che questa cosa l'avremmo vista in seguito.

Fammi sapere.