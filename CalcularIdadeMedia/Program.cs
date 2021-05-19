using System;
using System.Globalization;

namespace CalcularIdadeMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade = 0, soma = 0, media = 0;
            int cont = 0;

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Calcula a idade e soma cada vez que a condicao for verdadeira
            while (idade >= 0)
            {
                soma = soma + idade;
                cont = cont + 1;
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }     
            
            if (cont == 0 )
            {
                Console.WriteLine("Impossivel calcular");
            }

            //Calcula e imprime o valor com a idade media de cada individo. 
            //"F2" para apenas duas casas decimais
            else
            {
                media = soma / cont;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
