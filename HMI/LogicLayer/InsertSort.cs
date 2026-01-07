using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LogicLayer
{
    public class InsertSort : Sorter
    {
        #region Propriétés
        /// <summary>
        /// Nom pour l'affichage dans l'ihm
        /// </summary>
        public string Name { get; } = "Tri par insertion";
        #endregion

        #region Méthodes
        public void Sort(int[] values)
        {
            for (int i = 1; i < values.Length; i++)
            {
                int key = values[i];
                int j = i - 1;
                while (j >= 0 && values[j] > key)
                {
                    values[j + 1] = values[j];
                    j--;
                }
                values[j + 1] = key;
            }
        }
        #endregion
    }
}
