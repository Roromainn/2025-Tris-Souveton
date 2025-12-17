using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    /// <summary>
    /// Classe pour la generation de tableaux aleatoires
    /// </summary>
    public class ArrayGenerator
    {
        #region--Méthodes--
        /// <summary>
        /// Génere un tableau aevc des valeurs aléatoires
        /// </summary>
        /// <param name="size">taille du tableau</param>
        /// <param name="min">valeur minimum du tableau</param>
        /// <param name="max">valeur maximale du tableau</param>
        /// <returns>tableau d'entier avec des valeurs aléatoires comprises entre le min et max</returns>
        public int[] GenerateRandomArray(int size, int min, int max)
        {
            int [] temp = new int[size];
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                temp[i] = rnd.Next(min, max+1);
            }
            return temp;
        }
        #endregion
    }
}
