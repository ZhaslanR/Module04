using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul04dz
{
    class Program
    {
        static void Main(string[] args)
        {
            const int countLighter = 5;
            Lighter[] lighter = new Lighter[countLighter] { new Lighter(2000, 200, "Winston", "Blue", 10.5, false), new Lighter(2001, 300, "Richmond", "Black", 11.5, true), new Lighter(2002, 400, "LD", "Yellow", 13.5, false), new Lighter(2003, 500, "LM", "Silver", 14.5, true), new Lighter(2005, 600, "Astana", "Red", 9.5, false) };
            foreach (Lighter i in lighter)
            {
                i.Show();
                Console.WriteLine();
            }
            Console.WriteLine("Количество зажигалок : {0}", countLighter);
            Console.ReadLine();
        }
    }
}
