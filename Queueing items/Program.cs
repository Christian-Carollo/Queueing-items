
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Numerics;

Queue<string> persone = new Queue<string>();

persone.Enqueue("Marco");
persone.Enqueue("Alessia");

do
{

    Console.WriteLine("Seleziona un Opzione:\n\n 1)Queue " +
    "\n\n 2)Dequeue " +
    "\n\n 3)Peek " +
    "\n\n 4)Visualizza tutta la coda " +
    "\n\n 5)Esci \n ");


    string input = Console.ReadLine();
    Console.WriteLine(" \n");

    switch (input){
        case "1":
         Queue();
            break;
        case "2":
         Dequeue();
            break;
        case "3":
         Peek();
            break;
        case "4": GetAllElement();
            break;
        case "5": Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Scelta non valida. Riprova.\n");
            break;
    }
    Console.Write("Vuoi fare altre operazioni? (s/n): \n");

} while (Console.ReadLine().ToLower() == "s");

void Queue()
    {
        Console.WriteLine("Digita una persona da accodare:\n");
        string elementoQueue = Console.ReadLine();
        Console.WriteLine(" \n");
        persone.Enqueue(elementoQueue);
        Console.WriteLine($"L'elemento {elementoQueue} è stato accodato con successo!\n");
    }


    void Dequeue()
    {
        if (persone.Count > 0)
        {
            string elementoDequeue = persone.Dequeue();
            Console.WriteLine($"L'elemento {elementoDequeue} è stato eliminato con successo!\n");
        }
        else
        {
            Console.WriteLine("La coda è vuota. Impossibile eliminare\n");
        }
    }


    void Peek()
    {
        if (persone.Count > 0)
        {
            string elementoPeek = persone.Peek();
            Console.WriteLine($"La persona in testa alla coda è {elementoPeek}\n");
        }
        else {
            Console.WriteLine("La coda è vuota\n");
        };
    }

    void GetAllElement()
    {
    if (persone.Count > 0)
    {
        Queue copiaQueue = new Queue(persone);

        Console.WriteLine("Persone in coda:\n");

        foreach (string elementAll in copiaQueue)
        {
            Console.WriteLine(elementAll + "\n");
        }
    } 
    else 
    {
        Console.WriteLine("La coda è vuota\n");
    }
}


