using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    /// <summary>
    /// Realisation de l'interface Sorter
    /// </summary>
    public class NoSort : Sorter
    {
        public string Name { get; } = "No Sort";
        #region--Méthodes--
        public void Sort(int[] values)
        {
        }
        #endregion
    }
}
