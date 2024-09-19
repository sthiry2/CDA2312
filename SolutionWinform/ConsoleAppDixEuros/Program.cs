using CLMetier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDixEuros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transaction t = new Transaction(5);
            t.DixEurosAtteint += T_DixEurosAtteint;
            t.Add1Euros();
            t.Add1Euros();
            t.Add1Euros();
            t.Add1Euros();
            t.Add1Euros();
            t.Add1Euros();
        }

        private static void T_DixEurosAtteint(Transaction sender)
        {
            Console.WriteLine("Enfin je suis riche!");
        }
    }
}
