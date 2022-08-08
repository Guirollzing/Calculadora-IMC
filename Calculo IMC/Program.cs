using System;
using System.Globalization;

namespace IMCcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;

            Console.WriteLine("Calculadora de IMC!");
            Console.WriteLine("Digite seu peso:");
            peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite sua altura:");
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            imc = peso / (altura * 2);

            Console.WriteLine("Seu indice de massa coporal é: " + imc.ToString("F2", CultureInfo.InvariantCulture));

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso!");
            }
            else if (imc <= 24.9)
            {
                Console.WriteLine("Peso normal!");
            }
            else if (imc <= 29.9)
            {
                Console.WriteLine("Acimado peso(Sobrepeso)!");
            }
            else if (imc <= 34.9)
            {
                Console.WriteLine("Obesidade I!");
            }
            else if (imc <= 39.9)
            {
                Console.WriteLine("Obesidade II!");
            }
            else
            {
                Console.WriteLine("Obesidade III!");
            }



        }
    }
}
