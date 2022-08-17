using System;

namespace Aula15
{
    class Program
    {
        static void Main(string[] args)
        {
            double escolha1, escolha2;
            double resultado;
            char escolha;

            inicio:

            Console.Clear();

            Console.WriteLine("Escolha uma opção de calculo numérico: [1] Adição | [2] Subtração | [3] Multiplicação | [4] Divisão");
            escolha = char.Parse(Console.ReadLine());

            Console.WriteLine("Escolha um número inteiro para cálculo: ");
            escolha1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha outro número inteiro para cálculo: ");
            escolha2 = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case '1':
                    resultado = escolha1 + escolha2;
                    break;
                case '2':
                    resultado = escolha1 - escolha2;
                    break;
                case '3':
                    resultado = escolha1 * escolha2;
                    break;
                case '4':
                    resultado = escolha1 / escolha2;
                    break;
                default:
                    resultado = 0 ;
                    break;
            }

            
            Console.WriteLine("o resultado da operação eh: {0}", resultado);
            

            Console.WriteLine("Deseja fazer outro Cálculo?[s/n]");
            escolha = char.Parse(Console.ReadLine());

            if (escolha == 's') {
                goto inicio;
            }
            else
            {
                Console.WriteLine("Fim do programa");
                Console.Clear();
            }
        }
    }
}
