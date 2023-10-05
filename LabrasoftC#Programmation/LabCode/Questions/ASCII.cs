using System;
using System.Collections.Generic;
using System.Linq;
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

        /*Escreva um programa em C/C# que solicita ao usuário que digite 5 caracteres. Em seguida, o programa 
     * deve contar quantas vogais, consoantes, números e caracteres especiais foram inseridos e exibir cada
     * um deles. Considere que os caracteres especiais são quaisquer caracteres que não são letras ou números.*/

        public static void CountCharType()
        {

        }
    }

    
}
