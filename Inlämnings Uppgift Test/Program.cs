using System;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in fem namn på flera rader");
            string[] namn = new string[5];
            for (int i = 0; i < namn.Length; i++)
            {
                namn[i] = Console.ReadLine();
            }
            Console.WriteLine("Skriv in deras åldrar på flera rader i samma ordning");
            int[] ålder = new int[namn.Length];
            for (int i = 0; i < ålder.Length; i++)
            {
                ålder[i] = int.Parse(Console.ReadLine());
            }
            int medelÅlder = (ålder[0] + ålder[1] + ålder[2] + ålder[3] + ålder[4]) / 5;
            Console.WriteLine("Medelåldern är: " + medelÅlder + " år");
            int äldst = ålder[0];
            string äldstnamn = namn[0];
            for (int i = 0; i < ålder.Length; i++)
            {
                if (äldst < ålder[i])
                {
                    äldst = ålder[i];
                    äldstnamn = namn[i];
                }
            }
            Console.WriteLine("Den äldsta personen är " + äldst + " år gammal och heter " + äldstnamn);
            Console.ReadKey();
        }
    }
}
