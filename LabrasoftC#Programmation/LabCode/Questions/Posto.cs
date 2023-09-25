using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabrasoftC_Programmation.LabCode.Questions
{
    public static class Posto
    {
        /*Um posto está vendendo combustíveis com a seguinte tabela de descontos:
Álcool Até 25 litros, desconto de 2% por litro
Acima de 25 litros, desconto de 4% por litro
Gasolina Até 25 litros, desconto de 3% por litro
Acima de 25 litros, desconto de 5% por litro
Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível 
(codificado da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser 
pago pelo cliente sabendo-se que o preço do litro da gasolina é R$ 2,70 e o preço do litro 
do álcool é R$ 1,90*/


        public static void CalculatorPrice()
        {
            double liter;
            string type;
            double percent;
            double total;
            double price = 2.70;


            Console.WriteLine("Digite a quantidade de litros");
            liter = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o tipo G ou A");
            type = Console.ReadLine();

            Console.WriteLine($"Qtd litro {liter} e tipo {type}");

            if (type.ToUpper().Equals("G"))
            {
              
                if (liter > 25)
                {
                    percent =0.05;
                }
                percent = 0.03;
            }
            else
            {
                price = 1.90;
                if (liter > 25)
                {
                    percent =0.04;
                }
                percent = 0.02;
            }
            percent *= (price);

            total = price * liter;

            total -= (percent * liter);
            

            Console.WriteLine("Total" + total );

        }
    }
}
