using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(1, 1);
                ContaCorrente conta2 = new ContaCorrente(1, 1);
                conta.Transferir(-5000, conta2);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException!");
                Console.WriteLine(ex.Message);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
