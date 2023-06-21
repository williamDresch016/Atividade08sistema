using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ativida08
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            int buscar = 2;
            int posicao;
            posicao = 3;
            string nome;
            string novo_usuario;
            while (true)
            {

                Console.WriteLine("Cadastro de usúarios\n");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Buscar");
                Console.WriteLine("3 - Deletar Usuario");
                Console.WriteLine("4 - Alterar ");
                Console.WriteLine("Digite Uma Opção");
                buscar = int.Parse(Console.ReadLine());

                if (buscar ==1)
                {
                    Console.WriteLine("Cadastrar um Novo Usuario");
                    nomes.Add(Console.ReadLine());

                    Console.WriteLine("Usuario Cadastrado com Sucesso");

                }

                if (buscar == 2)
                {
                    Console.WriteLine("Digite a Posição que quer buscar: ");
                    posicao = int.Parse(Console.ReadLine());

                    Console.WriteLine("O nome é:"+nomes[posicao]);
                
                }
                if (buscar == 3)
                {
                    Console.WriteLine("Digite a posição que deseja deletar");

                    posicao = int.Parse(Console.ReadLine());
                    nomes.RemoveAt(posicao);

                } 
                if (buscar == 4)
                {
                    Console.WriteLine("Digite o nome de quem quer alterar");
                    nome = Console.ReadLine();
                    Console.WriteLine("Digite um novo usuario");
                    novo_usuario = Console.ReadLine();
                    posicao = nomes.IndexOf(nome);
                    nomes[posicao] = novo_usuario;
                }



           

            }




        }
    }
}
