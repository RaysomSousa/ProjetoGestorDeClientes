using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGestorDeClientes
{
    class Program
    {
        struct Cliente
        {
            public string Nome;
            public string Email;
            public string CPF;
        }

        static List<Cliente> clientes = new List<Cliente>();

        enum Menu { Listagem = 1, Adicionar =2 ,Remover =3 , Sair =4}
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Sistema de clientes - Bem vindo!");
                Console.WriteLine("1.Listagem \n2.Adicionar\n3.Remover\n4.Sair");
                int intOp = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)intOp;
                switch (opcao)
                {
                    case Menu.Listagem:
                        Listagem();
                        break;
                    case Menu.Adicionar:
                        Adicionar();
                        break;
                    case Menu.Remover:
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }
                Console.Clear();
            }
        }
        static void Adicionar()
        {
            Cliente cliente = new Cliente();
           
            Console.WriteLine("Cadastro de clientes: ");
            Console.WriteLine("Nome do cliente: ");
            cliente.Nome = Console.ReadLine();
            Console.WriteLine("Email do cliente: ");
            cliente.Email = Console.ReadLine();
            Console.WriteLine("CPF do cliente: ");
            cliente.CPF = Console.ReadLine();

            clientes.Add(cliente);
            Console.WriteLine("cadastro concluído, aperte ENTER para sair.");
            Console.ReadLine();
        }
        static void Listagem()
        {
            if (clientes.Count > 0)
            {
                Console.WriteLine("Lista de clientes: ");
                int i = 0;
                foreach (Cliente cliente in clientes)
                {
                    Console.WriteLine($"ID: {i}");
                    Console.WriteLine($"Nome: {cliente.Nome}");
                    Console.WriteLine($"Email: {cliente.Email}");
                    Console.WriteLine($"CPF: {cliente.CPF}");
                    Console.WriteLine("=============================");
                    i++;

                }
            }
            else
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
            }
            Console.WriteLine("cadastro concluído, aperte ENTER para sair.");
            Console.ReadLine();
        }
    }
}
