using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableau_tier
{
    class Program
    {
        static void Main(string[] args)
        {
            // saisie du nombre de cases du vectuer
            Console.Write("nombre de cases = ");
            int nb = int.Parse(Console.ReadLine());

            // declaration du vecteur
            int[] vec = new int[nb];

            //saisie du vecteur
            for (int k = 0; k < nb; k++)
            {
                Console.Write("nombre n°" + k + " = ");
                vec[k] = int.Parse(Console.ReadLine());
            }

            // premier affichage du vecteur non trie
            for (int k = 0; k < nb; k++)
            {
                Console.Write(vec[k] + " ");
            }

            //tri par insertion
            for (int i = 0; i < nb; i++)
            {

                // enregistrement de la case trier
                int sauv = vec[i];

                // recherche de la bonne position et decalages
                int j = i - 1;
                while (j >= 0 && sauv < vec[j])
                {
                    vec[j + 1] = vec[j];
                    j--;
                }

                // insertion de la valeur
                vec[j + 1] = sauv;

                // affichage du vecteur en cours de trie
                Console.WriteLine();
                for (int k = 0; k < nb; k++)
                {
                    Console.Write(vec[k] + " ");
                }

            }

            Console.ReadLine();
        }
    }
}