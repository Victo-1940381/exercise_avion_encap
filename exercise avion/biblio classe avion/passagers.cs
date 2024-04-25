using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblio_classe_avion
{
    /// <summary>
    /// représente un passager d'un avion
    /// </summary>
    public class passagers
    {
        private string _nom;
        private string _cordonné_siege;
        /// <summary>
        /// contructeur d'un passager
        /// </summary>
        /// <param name="nom">le nom du passager</param>
        /// <param name="cordonné_siege">la coordonné de son siege</param>
        public passagers(string nom, string cordonné_siege)
        {
            this._nom = nom;
            this._cordonné_siege = cordonné_siege;
        }
    }
}
