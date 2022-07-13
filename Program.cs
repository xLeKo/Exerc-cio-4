using System;

namespace Exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de acres: ");
            int acres = int.Parse(Console.ReadLine());

            double valor = acres;
            double desconto = 1;

            Console
                .WriteLine("Qual é o tipo da praga?\nTipo 1 – ervas daninhas\nTipo 2 – gafanhotos \nTipo 3 – broca \nTipo 4 – todos acima");
            int tipo = int.Parse(Console.ReadLine());

            switch (tipo)
            {
                case 1:
                    valor *= 50;
                    break;
                case 2:
                    valor *= 100;
                    break;
                case 3:
                    valor *= 150;
                    break;
                case 4:
                    valor *= 250;
                    break;
            }
            if (valor >= 750)
            {
                desconto -= 0.1;
            }
            if (acres >= 1000)
            {
                desconto -= 0.05;
            }

            valor *= desconto;

            Console.WriteLine("O valor final será de " + valor);
        }
    }
}
