﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblio_classe_avion
{
    /// <summary>
    /// represente un section de sieges
    /// </summary>
    public class Section : Siege
    {
       
        /// <summary>
        /// constructeur d'une sect
        /// </summary>
        /// <param name="classe">la classe du siège</param>
        public Section(string classe,string nom,int numéro_siege,char lettre_siege) : base(classe,nom, numéro_siege,lettre_siege)
        {
           
        }
    }
}
