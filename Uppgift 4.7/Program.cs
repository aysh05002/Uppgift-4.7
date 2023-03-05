using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv in ett meddelande");
        string meddelande = Console.ReadLine();
        Console.WriteLine("Skriv ett tal för hur många steg ska medelandet för flytas åt höger");
        int steg = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < meddelande.Length; i++)
        {
            for (int j = 0; j <= steg; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(meddelande[i]);
        }
    }
}