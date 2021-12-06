using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Inputs
{
    /// <summary>
    /// Classe para leitura dos dados de um cliente atraves do console
    /// </summary>
    public class ClienteInput
    {
        /// <summary>
        /// Metodo para ler nome do cliente informado
        /// </summary>
        /// <returns>Valor do nome do cliente retornado pelo usuario no prompt</returns>
        public string LerNome()
        {
            Console.Write("Informe o nome do cliente: ");
            return Console.ReadLine();

        }

        /// <summary>
        /// Metodo para ler o email do cliente informado
        /// </summary>
        /// <returns>Valor do email do cliente retornado pelo usuario no prompt</returns>
        public string LerEmail()
        {
            Console.Write("Informe o email do cliente: ");
            return Console.ReadLine();

        }

        /// <summary>
        /// Metodo para ler o CPF do cliente informado 
        /// </summary>
        /// <returns>valor do CPF do cliente retornado pelo usuario no prompt</returns>
        public string LerCpf()
        {
            Console.Write("Informe o CPF do cliente: ");
            return Console.ReadLine();

        }




    }
}
