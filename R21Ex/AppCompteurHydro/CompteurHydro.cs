using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCompteurHydro
{
    public class CompteurHydro : ICompteurHydro
    {
	    //stcok la consomation actuell exprimé en kwh	
		private int m_consommationActuelle;
        
		
		public int ConsommationActuelle
        {
            get { return m_consommationActuelle;  }
        }


        public CompteurHydro()
        {
            m_consommationActuelle = 0;
        }
		/// <summary>
        /// Mettre a jour la consommation actuelle selon la quantité consommer
        /// </summary>
        /// <param name="pQuantitéKwh"></param>
		public void Consommer(int pQuantitéKwh)
        {
            m_consommationActuelle -= pQuantitéKwh;
        }
    }
}
