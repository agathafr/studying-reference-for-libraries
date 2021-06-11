using StudentBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBank.InternalSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(458, 455789);
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}
