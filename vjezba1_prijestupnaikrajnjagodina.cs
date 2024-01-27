using System;

class Program
{
    static void Main(string[] args)
    {
        int pocetnaGodina = 1900;
        int krajnjaGodina = 2100;

        Console.WriteLine("Prijestupne godine u razdoblju od {0} do {1} su:", pocetnaGodina, krajnjaGodina);

        for (int godina = pocetnaGodina; godina <= krajnjaGodina; godina++)
        {
            if (godina % 400 == 0 || (godina % 4 == 0 && godina % 100 != 0))
            {
                Console.WriteLine(godina);
            }
        }
    }
}