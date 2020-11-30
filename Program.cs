using System;

namespace Exercicio_1_de_fixa_o_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descubra se você pode votar");
            Console.WriteLine("-------------");

            Console.WriteLine("Digite o ano que você nasceu: ");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano atual: ");
            int anoatual = int.Parse(Console.ReadLine());

            int idade = anoatual - ano;

            if(idade >=16 && idade <=70)
            {
                Console.WriteLine("A sua idade é: "+idade);
                Console.WriteLine("Parabéns você pode votar!");
            }else{
                Console.WriteLine("A sua idade é: "+idade);
                Console.WriteLine("A idade mínima para votar é 16 e máxima 70");
                 Console.WriteLine("Poxa! Tente novamente em alguns anos");
            }
        }
    }
}
