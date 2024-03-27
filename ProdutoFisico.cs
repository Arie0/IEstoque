using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3
{
    [System.Serializable]
    class ProdutoFisico : Produto, IEstoque
    {
        public float frete;
        private int estoque;

        public ProdutoFisico(string nome, float preco, float frete)
        {
            this.nome = nome;
            this.preco = preco;
            this.frete = frete;
           
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine($"Adicionar Entrada no estoque do Produto {nome}");
            Console.WriteLine($"Digita a qtd que você quer dar entrada: ");
            int entrada = int.Parse(Console.ReadLine());
            estoque += entrada;
            Console.WriteLine("Entrada Registrada");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar saida no estoque do Produto {nome}");
            Console.WriteLine("Digita a qtd que você quer dar baixa: ");
            int entrada = int.Parse(Console.ReadLine());
            estoque -= entrada;
            Console.WriteLine("Saída Registrada");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Preco: {preco}");
            Console.WriteLine($"Estoque: {estoque}");
            Console.WriteLine($"Frete: {frete}");
            Console.WriteLine("******************************");
        }
    }
}
