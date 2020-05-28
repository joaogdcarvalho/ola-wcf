using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Usuário: ");
            string usuario = Console.ReadLine();

            var servico = new ServicoClient();
            
            Console.WriteLine(servico.Mensagem(usuario));
            Console.ReadKey();
        }
    }
}
