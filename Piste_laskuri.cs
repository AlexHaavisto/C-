using System;

namespace Piste_laskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            double pistemäärä;
            Console.Write("Pistemäärä? ");
            pistemäärä = double.Parse(Console.ReadLine());

            if (pistemäärä < 0)
                Console.WriteLine("Virheellinen pistemäärä!");
            else if (pistemäärä <= 10)
                Console.WriteLine("Arvosana on 0");
            else if (pistemäärä <= 20)
                Console.WriteLine("Arvosana on 1");
            else if (pistemäärä <= 30)
                Console.WriteLine("Arvosana on 2");
            else if (pistemäärä <= 40)
                Console.WriteLine("Arvosana on 3");
            else if (pistemäärä <= 50)
                Console.WriteLine("Arvosana on 4");
            else if (pistemäärä <= 60)
                Console.WriteLine("Arvosana on 5");
            else
                Console.WriteLine("Virheellinen pistemäärä!");
        }
    }
}
