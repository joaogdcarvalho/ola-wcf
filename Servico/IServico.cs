using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Servico
{
    [ServiceContract]
    public interface IServico
    {
        [OperationContract]
        string Mensagem(string pstrNome);
    }
}
