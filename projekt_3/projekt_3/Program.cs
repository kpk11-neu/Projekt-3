using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace projekt_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enemy nem = new Enemy(100,10,"fiú");
            nem.Skeleton();
            nem.Magician();
            Console.WriteLine(nem.ToString());
            Console.ReadLine();
        }
    }
}
