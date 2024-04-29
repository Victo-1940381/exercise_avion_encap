using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblio_classe_avion
{

    /// <summary>
    /// représente une ranger de section de siege
    /// </summary>
    public class Ranger : Section
    {    
        private int _num_siege;
        public Ranger(string classe,char lettre_siege_section,int num_siege) : base(classe,lettre_siege_section)
        {
            this._num_siege = num_siege;
        }
    }
}
