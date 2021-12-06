using Newtonsoft.Json;
using Projeto01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Repositories
{
    /// <summary>
    /// Classe para garavar dados do cliente em um arquivo JSON
    /// </summary>
    public class ClienteRepository
    {

        /// <summary>
        /// Metodo para exportar dados de um cliente pra arquivo json
        /// </summary>
        /// <param name="cliente">Objeto da entidade cliente</param>
        public void ExportarDados(Clientes cliente)
        {
            //criar arqivo em modo de gravação
            var writer = new StreamWriter($"c:\\temp\\cliente_{cliente.IdCliente}.json");

            //converter os dados do cliente em json
            var json = JsonConvert.SerializeObject(cliente, Formatting.Indented);

            //gravar o conteudo JSON no arquivo
            writer.WriteLine(json);
            writer.Close(); //fechar o arquivo json


        }
    }
}
