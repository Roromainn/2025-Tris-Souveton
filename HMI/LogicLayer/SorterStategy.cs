using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace LogicLayer
{
    public class SorterStrategy
    {
        #region Propriétés
        /// <summary>
        /// Dictionnaire avec le nom et objet du tri
        /// </summary>
        public Dictionary<string, Sorter> Names { get; } = new Dictionary<string, Sorter>();
        #endregion

        #region Méthodes
        /// <summary>
        /// Enregistre le tri avec son nom et object
        /// </summary>
        /// <param name="name">nom du tri</param>
        /// <param name="sorter">objet du tri</param>
        public void RegisterSorter(string name, Sorter sorter)
        {
            Names[name] = sorter; 
        }

        /// <summary>
        /// Trouve le tri par son nom
        /// </summary>
        /// <param name="name">nom du tri</param>
        /// <returns>l'object du tri correspondant</returns>
        public Sorter ChooseSorter(string name)
        {
            return Names[name];
        }

        #endregion
    }
}

