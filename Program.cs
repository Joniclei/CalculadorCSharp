using System;

namespace Calculando
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Qual operacao quer fazer:");
      Console.WriteLine("1- Adicao");
      Console.WriteLine("2- Subtracao");
      Console.WriteLine("3- Multiplicao");
      Console.WriteLine("4- Divisao");


      int operacao = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o primeiro numero: ");
      int num1 = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o segundo numero: ");
      int num2 = int.Parse(Console.ReadLine());


      int resultado = 0;

      switch (operacao)
      {
        case 1:
          {

            resultado = Adicao(num1, num2);
            break;
          }

        case 2:
          {
            resultado = Subtracao(num1, num2);
            break;
          }
        case 3:
          {
            resultado = Multiplicao(num1, num2);
            break;
          }
        case 4:
          {
            resultado = Divisao(num1, num2);
            break;
          }
        default :
            Console.WriteLine ("Errado, digite uma escolha acertiva:");
            break;


      }

      Console.WriteLine("resultado : {0}",resultado);
      Console.WriteLine($"resultado : {resultado}");

    }

    public static int Adicao(int a, int b)
    {
      int result = a + b;
      return result;
    }

    public static int Subtracao(int a, int b)
    {
      int res = a - b;
      return res;
    }

    public static int Multiplicao(int x, int y)
    {
      int r = x * y;
      return r;
    }

    public static int Divisao(int num1, int num2)
    {
      int olhaai = num1 / num2;
      return olhaai;
    }


  }
}
