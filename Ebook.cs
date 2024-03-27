using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    [System.Serializable]
    class Ebook : Produto, IEstoque
    {
        public string autor;
        private int vendas;

        public Ebook(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

public void AdicionarEntrada()
        {
            Console.WriteLine("Não é possível dar entrada, pois é um produto digital.");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar vendas no Ebook {nome}");
            Console.WriteLine("Digita a qtd de vendas que você quer dar entrada: ");
            int entrada = int.Parse(Console.ReadLine());
            vendas -= entrada;
            Console.WriteLine("Saída Registrada");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Preco: {preco}");
            Console.WriteLine($"Vendas: {vendas}");
            Console.WriteLine("******************************");
        }
    }
}
