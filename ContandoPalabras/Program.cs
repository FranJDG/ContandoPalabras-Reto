using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Reto #7
 * CONTANDO PALABRAS
 * Fecha publicación enunciado: 14/02/22
 * Fecha publicación resolución: 21/02/22
 * Dificultad: MEDIA
 *
 * Enunciado: Crea un programa que cuente cuantas veces se repite cada palabra y que muestre el recuento final de todas ellas.
 * - Los signos de puntuación no forman parte de la palabra.
 * - Una palabra es la misma aunque aparezca en mayúsculas y minúsculas.
 * - No se pueden utilizar funciones propias del lenguaje que lo resuelvan automáticamente.
 */

namespace ContandoPalabras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe una frase para comprobar las palabras que se repiten.");
            string frase = Console.ReadLine();

            ContadorPalabras(frase);
        }

        static void ContadorPalabras(string texto)
        {
            string texto1 = texto.ToLower().Trim();
            string[] palabras = texto1.Split(' ');
            string[] palabrasRepetidas = new string[palabras.Length];
            int a = 0;

            foreach (string palabra in palabras)
            {
                int num = 0;
                for (int i = 0; i < palabras.Length; i++)
                {
                    if (palabra == palabras[i])
                    {
                        num++;                        
                    }
                }                
                palabrasRepetidas[a] = palabra.ToString() + " => " + Convert.ToString(num);
                a++;
            }

            string[] palabrasSinDuplicados = palabrasRepetidas.Distinct().ToArray();

            foreach(string palabra in palabrasSinDuplicados)
            {
                Console.WriteLine(palabra);
            }
        }
    }
}
