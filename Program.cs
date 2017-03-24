using System;

namespace UnicamFattoriale
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stampo dei messaggi di cortesia per l'utente, così lo guido all'utilizzo del programma
            Console.WriteLine("Questo programma calcola il fattoriale di un numero");
            Console.Write("Digita un numero intero e premi invio: ");

            //Console.ReadLine si mette in attesa che l'utente digiti qualcosa e prema invio.
            //Quando ha premuto invio, il testo che ha digitato lo assegno ad una variabile di tipo string.
            string testoDigitatoDallUtente = Console.ReadLine();

            //Interpreto il testo come un numero intero
            //Attenzione: questa istruzione fallirà se l'utente ha digitato un testo
            //che non è interpretabile come un numero! (Es. ABCD)
            int numero = int.Parse(testoDigitatoDallUtente);

            //Calcolo il fattoriale: qui ci sono degli errori!
            int risultato = 0;
            while (numero >= 0) {
                risultato *= numero;
                numero--;
            }

            //Stampo il risultato
            Console.WriteLine($"Il fattoriale di {numero} e' {risultato}");
            //Attendo che l'utente prema un tasto prima di uscire, altrimenti 
            Console.ReadKey();
        }
    }
}
