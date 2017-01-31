using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Character c = new Character();
            Planet p = new Planet();
            p.Type = PlanetType.Desert;

            Console.WriteLine(p );

            /*string s = "  Kenan Ca se y  ";

            string modifiedS = s.Replace(" ", "");
            int letterCount = modifiedS.Length;

            byte b;
            sbyte sb;

            short sh;
            ushort ush;

            int i;
            uint intcount = 0;

            long l;
            ulong count = 0;

            Console.WriteLine(modifiedS);*/

            Console.ReadKey();
        }
    }
}
