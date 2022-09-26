/**
 * Jeu du nombre caché
 * author : Beaudisson
 * Date 20/09/2022
 */
using System;

namespace NombreCache
{
    class Program
    {
        static void Main(string[] args)
        {
            int valeur, essai;
            int nbr;
            essai = 0;
            valeur = 0;
            nbr = 1;
            bool correct = false;
            while (!correct)
            {
                try
                {
                    Console.Write("entrez le nombre à chercher = ");
                    valeur = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saisir un nombre réél");
                }
            }

            
            Console.Clear();
            correct = false;
            while (!correct) 
            {
                try
                {
                    Console.Write("entrez un essai = ");
                    essai = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saisir un nombre réél");
                }
            }


            while (essai != valeur)
            {
                if (essai > valeur)
                {
                    Console.WriteLine("Trop grand");
                }
                else
                {
                    Console.WriteLine("Trop petit");
                }
                correct = false;
                while (!correct)
                {
                    try
                    {
                        Console.Write("entrez un essai = ");
                        essai = int.Parse(Console.ReadLine());
                        correct = true;
                    }
                    catch
                    {
                        Console.WriteLine("erreur de saisie");
                    }
                }
                nbr++;
            }
            
            
            Console.WriteLine("Bonne réponse vous avez trouver en "+nbr+" fois");
            Console.ReadLine();
        }
    }
}
