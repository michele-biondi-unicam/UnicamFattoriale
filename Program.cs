using System;
using System.Numerics;

namespace UnicamFattoriale
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stampo dei messaggi di cortesia per l'utente, così lo guido all'utilizzo del programma
            Console.WriteLine("Questo programma calcola il fattoriale di un numero");
            while(true){
                Console.Write("Digita un numero intero e premi invio(digita 'quit' per uscire): ");

                //Console.ReadLine si mette in attesa che l'utente digiti qualcosa e prema invio.
                //Quando ha premuto invio, il testo che ha digitato lo assegno ad una variabile di tipo string.
                string testoDigitatoDallUtente = Console.ReadLine();
                if (testoDigitatoDallUtente == "quit"){
                    break;
                }

                //Interpreto il testo come un numero intero
                //Attenzione: questa istruzione fallirà se l'utente ha digitato un testo
                //che non è interpretabile come un numero o ha digitato un numero troppo grande! (Es. ABCD)
                try{
                    uint numero = uint.Parse(testoDigitatoDallUtente);
                    BigInteger risultato = 1;
                        uint indice = numero; // Variabile di appoggio per il calcolo del fattoriale
                        //Calcolo il fattoriale
                        while(indice >= 2){
                            risultato *= indice;
                            indice--;
                        }
                            
                        Console.WriteLine($"Il fattoriale di {numero} e' {risultato}\n");
                    
                } catch (Exception ex) when (
                    ex is ArgumentNullException ||
                    ex is FormatException ||
                    ex is OverflowException
                ){
                    Console.WriteLine("Spiacente, non posso calcolare il fattoriale per questo valore.\n");
                }
            }


            
        }
    }
}
