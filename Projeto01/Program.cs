
using Projeto01.Entities;
using Projeto01.Inputs;
using Projeto01.Repositories;
using System; //importaçoes de bibieotecas

//namespace -> define a localixaao da classe dentro do projeto
namespace Projeto01
{

    //  definicao da classe
    class Program
    {
        // metodo resposnavel por executar o projeto
        static void Main(string[] args)
        {



            var cliente = new Clientes();
            var input = new ClienteInput();

            Console.WriteLine("\nENTRE COM OS DADOS DO CLIENTE\n");

            cliente.IdCliente = Guid.NewGuid();
            cliente.Nome = input.LerNome();
            cliente.Email = input.LerEmail();
            cliente.Cpf = input.LerCpf();

            //Imprimir os dado do cliene no console


            Console.WriteLine("\nDados do Cliente:");
            Console.WriteLine($"\tID.....: {cliente.IdCliente}");
            Console.WriteLine($"\tNOME...: {cliente.Nome}");
            Console.WriteLine($"\tEmail..: {cliente.Email}");
            Console.WriteLine($"\tCPF....: {cliente.Email}");

            //Gravar os daods do cliente em arquivo....
            var repository = new ClienteRepository();
            repository.ExportarDados(cliente);

            Console.WriteLine("\nARQUIVO JSON GERADO COM SUCESSO");


        }
    }
}