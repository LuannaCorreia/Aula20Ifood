using System;

namespace Aula20Ifood
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurante info = new Restaurante();
            info.Nome = "Japalig";
            info.Endereco = "Rua Joaquim Manoel, 222, 158242-65 São Paulo";
            info.MostrarDados();

            //
            Cliente cliente = new Cliente();
            cliente.Nome = "Luanna Correia";
            cliente.Endereco = "Rua Tatuapé";

            string resposta = null;

            while(resposta != "Sim"){
            cliente.MostrarDados();
            resposta = Console.ReadLine();
            }

            //
            Console.ForegroundColor = ConsoleColor.Red;
            Pedidos Lasanha = new Pedidos("Yakissoba", "Sabor: Tradicional", "Porção Individual: R$20" );
            System.Console.WriteLine($"\n{Lasanha.Nome}\n{Lasanha.Descricao}\n{Lasanha.Preco}");
            Console.ResetColor();
        }
    }
}