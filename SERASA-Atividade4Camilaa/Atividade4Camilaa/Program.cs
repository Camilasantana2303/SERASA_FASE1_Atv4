using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4Camilaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome;
            String produto1;
            String produto2 = "Perfume";
            int item1;
            int item2;


            Console.WriteLine("Bem-vindo ao sistema de estoque do Conradito");
            Console.WriteLine("Digite o nome do funcionário responsável: ");
            nome=Console.ReadLine();


            Console.WriteLine("\n\n\nO cadastro de estoque será feito no nome de "+nome);

            Console.WriteLine("\n\n--CADASTRO DE PRODUTOS");
            Console.WriteLine("Digite o nome do produto 1: ");
            produto1=Console.ReadLine();
            Console.WriteLine("Digite a quantidade em estoque de Calça: ");
            item1=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do produto 2: ");
            produto2=Console.ReadLine();
            Console.WriteLine("Digite a quantidade em estoque de perfume: ");
            item2=int.Parse(Console.ReadLine());

            Console.WriteLine("\n- Os produtos foram cadastrados com sucesso!\n");

            Console.WriteLine($"-- LISTA DE PRODUTOS CADASTRADOS POR {nome}:");
            Console.WriteLine($"{produto1} contém {item1} itens em estoque");
            Console.WriteLine($"{produto2} contém {item2} itens em estoque");
            Console.WriteLine($"Total de itens no estoque: {item1+item2}");
            Console.WriteLine("\n-----FIM DE ESTOQUE-----");

            Console.ReadKey();
        }
    }
}
