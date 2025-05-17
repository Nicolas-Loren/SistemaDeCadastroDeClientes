using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CadastroClientes {
class URI {
    static List<Cliente> clientes = new List<Cliente>();

    static void Main(string[] args) {
            bool Executando = true;
            while (Executando) {
                // Menu de opções
                Console.WriteLine("Sistema de Cadastro de Clientes");
            Console.WriteLine("1. Adicionar Cliente");
            Console.WriteLine("2. Ver Clientes");
            Console.WriteLine("3. Editar");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            short opcao = short.Parse(Console.ReadLine());
            // Estrutura de repetição para o menu
            switch (opcao) {
                case 0:
                    System.Environment.Exit(0);
                    break;
                case 1:
                    AdicionarClientes();
                    break;
                case 2:
                    VerClientes();
                    break;
                case 3:
                    EditarClientes();
                    break;
                default: Console.WriteLine("Selecione uma opção válida");
                    break;
            }
                }
        }
        static void AdicionarClientes() {
            // Recolhendo informações dos clientes (Nome, E-mail, WhatsApp e CPF)
            Console.WriteLine("Informar seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informar seu E-mail: ");
            string email = Console.ReadLine();
            Cliente cliente = new Cliente(nome, email);
            clientes.Add(cliente);
        }
    static void VerClientes() {
        // Acessar clientes cadastrados
        foreach (Cliente cliente in clientes) {
            Console.WriteLine("Nome: " + cliente.Nome);
            Console.WriteLine("E-mail: " + cliente.Email);
            Console.WriteLine("--------------------------------------");
        }
    }
    static void EditarClientes() {
            // Editar clientes cadastrados
            Console.WriteLine("Qual nome você gostaria de editar? ");
            string nome = Console.ReadLine();
            Cliente cliente = clientes.Find(c => c.Nome == nome);
            Console.WriteLine("\nDigite o novo nome:");
            string novoNome = Console.ReadLine();
            Console.WriteLine($"\nNome alterado para: {novoNome}");
            Console.WriteLine("\nDigite o novo e-mail:");
            string novoEmail = Console.ReadLine();
            Console.WriteLine($"\nE-mail alterado para: {novoEmail}");

            cliente.Nome = novoNome;
            cliente.Email = novoEmail;
        }
}
    //Criando a classe Cliente
    class Cliente {

        //Setando o email e nome
        public string Nome { get; set; }
        public string Email { get; set; }

        public Cliente(string nome, string email) {
            Nome = nome;
            Email = email;
        }
    }
}