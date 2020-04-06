using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora\n");
            Console.WriteLine("Selecione as operações que você deseja fazer:\n1-Operações Básicas\n2-Potências e Raizes\n3-Funções\n4-Sair\n");
            int opcao = int.Parse(Console.ReadLine());            
            Operacoes Calculadora = new Operacoes();

            if (opcao == 1) // Operações Básicas
            {
                Console.WriteLine("digite a operação desejada com os números(separada por espaços)");
                string[] op = Console.ReadLine().Split(' ');
                float n1 = float.Parse(op[0]);
                char sinal = char.Parse(op[1]);
                float n2 = float.Parse(op[2]);

                if (sinal == '+')
                {
                    Console.WriteLine(Calculadora.Soma(n1, n2));
                }

                else if (sinal == '-')
                {
                    Console.WriteLine(Calculadora.Subtracao(n1, n2));
                }

                else if (sinal == '*' || sinal == 'x')
                {
                    Console.WriteLine(Calculadora.Multiplicacao(n1, n2));
                }

                else if (sinal == '/')
                {
                    Console.WriteLine(Calculadora.Divisao(n1, n2));
                }

                else { Console.WriteLine("Operação Inválida"); }
            }

            if(opcao == 2) // Potências e Raízes
            {
                Console.WriteLine("Selecione a operação:\n1-Raiz Quadrada\n2-Potência\n");
                int opcaoPotRaiz = int.Parse(Console.ReadLine());

                if(opcaoPotRaiz == 1) 
                {
                    Console.Write("Insíra o valor: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine(Calculadora.RaizQuadrada(a));
                }

                if(opcaoPotRaiz ==2)
                {
                    Console.WriteLine("Insíra o valor e a potência que você deseja elevar(Separados por espaço)");
                    string[] vp = Console.ReadLine().Split(' ');
                    float valor = float.Parse(vp[0]);
                    int pot = int.Parse(vp[1]);
                    Console.WriteLine(Calculadora.Potencia(valor, pot));
                }

            }

            if(opcao == 3) 
            {
                Console.WriteLine("Selecione uma opção\n1-Descobrir as raizes de uma função de segundo grau");
                int opcaoFuncao = int.Parse(Console.ReadLine());

                if(opcaoFuncao == 1) 
                {
                    Console.WriteLine("Digite a função de segundo grau no formato a x² + b x + c (com os espaços):");
                    string[] h = Console.ReadLine().Split(' ');
                    double a = double.Parse(h[0]);
                    double b = double.Parse(h[3]);
                    double c = double.Parse(h[6]);
                    Console.WriteLine(Calculadora.RaizdeFuncao(a, b, c));
                }
            }

            else { } //Finalizar o programa
        }
    }
}
