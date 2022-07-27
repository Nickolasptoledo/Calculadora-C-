using System;

namespace Calculadora
{

    class Program
    {
        public static void Main(string[] args)
        {
            int op = 1;
            Console.WriteLine("-- Deseja ligar a caluladora? --\n" +
                "0 - Desligar\n" +
                "1 - Ligar");
            Console.Write("Digite a opção escolhida: ");
            int OnOff = int.Parse(Console.ReadLine());

            if (OnOff == 1)
            {
                do
                {
                    Console.WriteLine("\n-- Escolha o cálculo que deseja realizar --\n" +
                    "1 - Soma\n" +
                    "2 - Subtrair\n" +
                    "3 - Multiplicação\n" +
                    "4 - Divisão");
                    Console.Write("Digite a opção escolhida: ");
                    int opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("\n-- SOMA --");
                            Console.Write("Entre com o primeiro valor: ");
                            int num1 = int.Parse(Console.ReadLine());
                            Console.Write("Entre com o segundo valor: ");
                            int num2 = int.Parse(Console.ReadLine());

                            int resultado = Soma(num1, num2);

                            Console.WriteLine($"Resultado: {resultado}");
                            break;

                        case 2:
                            Console.WriteLine("\n-- SUBTRAIR --");
                            Console.Write("Entre com o primeiro valor: ");
                            num1 = int.Parse(Console.ReadLine());
                            Console.Write("Entre com o segundo valor: ");
                            num2 = int.Parse(Console.ReadLine());

                            resultado = Subtrair(num1, num2);

                            Console.WriteLine($"Resultado: {resultado}");
                            break;

                        case 3:
                            Console.WriteLine("\n-- MULTIPLICAÇÃO --");
                            Console.Write("Entre com o primeiro valor: ");
                            num1 = int.Parse(Console.ReadLine());
                            Console.Write("Entre com o segundo valor: ");
                            num2 = int.Parse(Console.ReadLine());

                            resultado = Multiplicacao(num1, num2);

                            Console.WriteLine($"Resultado: {resultado}");
                            break;

                        case 4:
                            Console.WriteLine("\n-- DIVISÃO --");
                            Console.Write("Entre com o primeiro valor: ");
                            num1 = int.Parse(Console.ReadLine());
                            Console.Write("Entre com o segundo valor: ");
                            num2 = int.Parse(Console.ReadLine());

                            resultado = Dividir(num1, num2);

                            Console.WriteLine($"Resultado: {resultado}");
                            break;

                        default:
                            Console.WriteLine("-- Erro --");
                            break;
                    }

                    Console.WriteLine("\nDeseja desligar a caluladora?\n" +
                        "0 - Sim\n" +
                        "1 - Não");
                    Console.Write("Digite a opção escolhida: ");
                    op = int.Parse(Console.ReadLine());
                } while (op != 1);
                MetodoDesligar();
            }
            else
            {
                Console.WriteLine("\n-- Desligando a Calculadora --");
            }
        }

        public static void MetodoDesligar()
        {
            Console.WriteLine("\n-- Desligando a Calculadora --");
        }

        public static int Soma(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiplicacao(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Dividir(int dividendo, int divisor)
        {
            if (DiferenteDeZero(divisor))
            {
                throw new Exception("Divisor não pode ser 0!");
            }

            return dividendo / divisor;

            bool DiferenteDeZero(int divisor)
            {
                if (divisor == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


    }

}
