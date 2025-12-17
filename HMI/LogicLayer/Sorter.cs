using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    /// <summary>
    /// Interface pour tier un tableau
    /// </summary>
    internal interface Sorter
    {
        /// <summary>
        /// Tri un tableau
        /// </summary>
        /// <param name="values">tableau d'entier a trier</param>
        public void Sort(int[] values);
        
    }
}
