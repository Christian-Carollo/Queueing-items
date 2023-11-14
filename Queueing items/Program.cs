
using System.Collections;
using System.Linq.Expressions;
using System.Numerics;

Queue<string> persone = new Queue<string>();

persone.Enqueue("Marco");
persone.Enqueue("Alessia");

do
{

    Console.WriteLine("Seleziona un Opzione:\n 1)Queue " +
    "\n 2)Dequeue " +
    "\n 3)Peek " +
    "\n 4)Visualizza tutta la coda " +
    "\n 5)Esci");


    string input = Console.ReadLine();

    switch(input){
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
            Console.WriteLine("Scelta non valida. Riprova.");
            break;
    }
    Console.Write("Vuoi fare altre operazioni? (s/n): ");

} while (Console.ReadLine().ToLower() == "s");

void Queue()
    {
        Console.WriteLine("Digita un elemento da accodare:");
        string elementoQueue = Console.ReadLine();
        persone.Enqueue(elementoQueue);
        Console.WriteLine($"L'elemento {elementoQueue} è stato accodato con successo!");
    }


    void Dequeue()
    {
        if (persone.Count > 0)
        {
            string elementoDequeue = persone.Dequeue();
            Console.WriteLine($"L'elemento {elementoDequeue} è stato eliminato con successo!");
        }
        else
        {
            Console.WriteLine("La coda è vuota. Impossibile eliminare");
        }
    }


    void Peek()
    {
        if (persone.Count > 0)
        {
            string elementoPeek = persone.Peek();
            Console.WriteLine($"La persona in testa alla coda è {elementoPeek}");
        }
        else {
            Console.WriteLine("La coda è vuota");
        };
    }

    void GetAllElement()
    {
        Queue copiaQueue = new Queue(persone);

        Console.WriteLine("Persone in coda:");

        foreach(string elementAll in copiaQueue)
        {
        Console.WriteLine(elementAll);
        }
    }


