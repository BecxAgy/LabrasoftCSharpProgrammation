using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabrasoftC_Programmation.LabCode.Questions
{
    public static class PraCtice
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
                    percent = 0.04;
                }
                percent = 0.02;
            }
            percent *= (price);

            total = price * liter;

            total -= (percent * liter);
            

            Console.WriteLine("Total" + total );

        }

       


        /*
         Na álgebra de inteiros foi definida uma nova operação chamada de maximização de inteiros. A
        maximização de dois números inteiros A e B segue as seguintes regras:
        1. Inicialmente fazemos A e B terem o mesmo número de dígitos, adicionando zeros à esquerda
        conforme necessário.
        2. Então cada dígito de A (do menos significativo ao mais significativo) é comparado com o dígito
        correspondente de B. Nesta comparação, o dígito de menor valor é eliminado do número a que
        pertence (se eles são iguais, nenhum é eliminado).
        3. O resultado da operação é a dupla de números formados pelos dígitos remanescentes. Caso não
        haja dígitos remanescentes em um dos números, o equivalente na dupla resultado para este número
        é -1.
        Por exemplo, considere a maximização de 453 e 92. Após o passo 1, teremos: 453 e 092; em
        seguida compara-se 4 > 0; 5 < 9 e 3>2. Será eliminado o 5 do primeiro número e serão eliminados
        o 0 e o 2 do segundo número. A dupla resultado será (43 e 9).
        Sua tarefa é escrever um programa em C, que calcule a operação maximização para dois inteiros
        entre 0 e 999
             */
        public static void Maximization()
        {
            int numA = 453;
            int numB = 92;

            int[] digitosA = new int[3];
            int[] digitosB = new int[3];
            int indexA = 0;
            int indexB = 0;

            // Separar os dígitos dos números
            for (int i = 2; i >= 0; i--)
            {
                digitosA[i] = numA % 10;
                digitosB[i] = numB % 10;
                numA /= 10;
                numB /= 10;
            }

            // Inicializar os resultados
            int resultadoA = 0;
            int resultadoB = 0;

            // Calcular o resultado
            for (int i = 0; i < 3; i++)
            {
                if (digitosA[i] > digitosB[i])
                {
                    resultadoA = resultadoA * 10 + digitosA[i];
                }
                else if (digitosB[i] > digitosA[i])
                {
                    resultadoB = resultadoB * 10 + digitosB[i];
                }

                if(digitosA[i] == digitosB[i])
                {
                    resultadoA = resultadoA * 10 + digitosA[i];
                    resultadoB = resultadoB * 10 + digitosB[i];
                }
            }

            // Se um número acabou e não houve eliminação, marque como -1
            if (resultadoA == 0)
            {
                resultadoA = -1;
            }
            if (resultadoB == 0)
            {
                resultadoB = -1;
            }

            Console.WriteLine(resultadoA + " " + resultadoB);
        }

    }
}
