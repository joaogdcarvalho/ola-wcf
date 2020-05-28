using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico
{
    public class Servico : IServico
    {
        public string Mensagem(string pstrNome)
        {
            return "Olá " + pstrNome + ". O Serviço WCF está funcionando!"; 
        }
    }
}
