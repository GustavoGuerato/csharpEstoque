using System;

namespace Estoque
{
    class Program 
    { 
        static void Main(string[] args)
        {
            Produto p = new Produto(); 
            Console.WriteLine("Coloque os dados do produto");
            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

        } 
    }
}
