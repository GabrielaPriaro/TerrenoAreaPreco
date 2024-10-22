//Problema "terreno"
//Fazer um programa para ler as medidas da largura e comprimento de um terreno retangular com uma
//casa decimal, bem como o valor do metro quadrado do terreno com duas casas decimais. Em seguida,
//o programa deve mostrar o valor da área do terreno, bem como o valor do preço do terreno, ambos com
//duas casas decimais

using System.Globalization;

namespace TerrenoAreaPreco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double larguraTerreno, comprimentoTerreno, areaTerreno, valorMetroQuadrado, precoTerreno;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a largura do terreno: ");
            larguraTerreno = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite o comprimento do terreno: ");
            comprimentoTerreno = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite o valor do metro quadrado: ");
            valorMetroQuadrado = double.Parse(Console.ReadLine(), CI);

            areaTerreno = larguraTerreno * comprimentoTerreno;
            precoTerreno = areaTerreno * valorMetroQuadrado;

            Console.WriteLine($"Area do terreno = {areaTerreno.ToString("F2", CI)}");
            Console.WriteLine($"Preco do terreno = {precoTerreno.ToString("F2", CI)}");
        }
    }
}
