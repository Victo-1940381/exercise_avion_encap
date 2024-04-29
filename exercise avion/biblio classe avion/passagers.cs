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
        private int _numéro_siege;
        private char _lettre_siege;
        /// <summary>
        /// contructeur d'un passager
        /// </summary>
        /// <param name="nom">le nom du passager</param>
        /// <param name="numéro_siege ">le numrero de son siege </param>
        /// <param name="lettre_siege">la lettre de son siege </param>
        public passagers(string nom, int numéro_siege,char lettre_siege)
        {
            this._nom = nom;
            this._numéro_siege = numéro_siege;
            this._lettre_siege = lettre_siege;
        }
    }
}
