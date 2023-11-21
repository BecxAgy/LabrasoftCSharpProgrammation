using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace LabrasoftC_Programmation.LabCode.Questions
{
    public static class ASCII
    {
        /*Escreva um programa que leia um caracter e diga se ele é uma vogal, consoante, número
ou um símbolo (qualquer outro caracter, que não uma letra ou número).*/

        public static void CaracterType()
        {
            //guardando no vetor  as vogais
            char[] vectorVowel = new char[] { 'a', 'e', 'i', 'o', 'u' };
            //pede
            Console.WriteLine("Digite um caracter:");


            //lê uma string
            char c = Console.ReadKey().KeyChar;
            c = char.ToLower(c);
            Console.WriteLine(c);

            if(char.IsLetter(c))
            {
                if(vectorVowel.FirstOrDefault(elementChar => c == elementChar) == c)
                {
                    Console.WriteLine("é vogal");
                }
                else { Console.WriteLine("é consoante"); }
            } else if(char.IsDigit(c)){

                Console.WriteLine("é caracter especial");

            }
            else
            {
                Console.WriteLine("é caracter especial");
            }


        
        }

        //usando ascii
        public static void CaracterType2() {
            char[] vectorVowel = new char[] { 'a', 'e', 'i', 'o', 'u' };
            bool isvowel = false;
            //pede
            Console.WriteLine("Digite um caracter:");


            //lê uma string
            char c = Console.ReadKey().KeyChar;
            c = char.ToLower(c);
            Console.WriteLine(vectorVowel.Length);
            //ENTRE 65 E 97
            if(c >= 'a' &&  c <= 'z')
            {
                for(int i = 0; i < vectorVowel.Length; i++)
                {
                    if (vectorVowel[i] == c)
                    {
                        Console.WriteLine("é vogal");
                        isvowel = true;
                    }
                }

                if(!isvowel)
                {
                    Console.WriteLine("é consoante");
                }
            }
            else if(c >= '0' && c <= '9')
            {
                Console.WriteLine("é digito");
            }
            else
            {
                Console.WriteLine("é especial");
            }
        }

        //    1- Dado dois arrays de números inteiros com 10 elementos imprima os números do primeiro array que não estão
        //presentes no segundo array.Lembrando que os números não podem ser repetidos no vetor 1 e vetor 2.
        public static void CaracterType3()
        {
            //um for para olhar para cada posição do vetor 1 
            int[] vetor1 = { 2, 3, 4, 5, 6, 12, 1, 23, 11, 32 };
            int[] vetor2 = { 2, 31, 4, 51, 16, 12, 1, 23, 111, 32 };

            //outro for para andar pelas posições seguintes

            //um if para verificar se o elemento do vetor 1 está no vetor 2
            int[] vetorDiff = new int[10];

            bool igual;
            int d = 0;
            for (int i = 0;i < 10;i++)
            {
                igual = false;
                for (int j = 0; j<10; j++)
                {
                    if (vetor1[i] == vetor2[j])
                    {
                        igual = true;
                        break;
                    }
                }
                if (!igual)
                {
                    vetorDiff[d] = vetor1[i];
                    Console.WriteLine(vetorDiff[d]);
                    d++;
                }
            }

            
        }
    }

    
}
