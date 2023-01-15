using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa_String5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string brojevi;

            Console.WriteLine("Unesite jedan cijeli i jedan decimalni broj odvojeni s razmakom: ");
            brojevi = Console.ReadLine();

            string x, y, z;

            string[] broj = brojevi.Split(' ', '.', ',');
            x = broj[0];
            y = broj[1];
            z = broj[2];

            Console.WriteLine("Prvi broj je " + x + ", drugi je " + y + " i treći je " + z);

            Console.ReadKey();
        }
    }
}
