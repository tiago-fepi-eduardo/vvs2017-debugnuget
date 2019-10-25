using System;
using NugetLab01;

namespace ConsoleLab
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Fight!");

            Lutar oLutar = new Lutar();

            Console.WriteLine("Onde estou: " + oLutar.Place);

            Console.WriteLine("End Fight!");

            Console.Read();
        }
    }
}
