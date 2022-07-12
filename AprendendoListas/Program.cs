using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> clientes = new List<string>();
            clientes.Add("Pedro");
            clientes.Add("João");
            clientes.Add("Bleno");
            clientes.Add("Wlademir");

            foreach (string cliente in clientes)
            {
                Console.WriteLine(cliente);
            }
           List<string> filtrada = clientes.FindAll(cliente => cliente.Length < 5);

            Console.WriteLine("-----------------");

            foreach (string cliente in filtrada)
            {
                Console.WriteLine(cliente);
            }
           

            Console.ReadLine();
        }
    }
}
