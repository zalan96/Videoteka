using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videoteka
{
	internal class Film
	{
		public string Cim { get; private set; }
		public string Kategoria { get; private set; }
		public int KiadasiEv { get; private set; }
		public bool Kolcsonozve { get; private set; }

		public Film(string cim, string kategoria, int kiadasiEv)
		{
			Cim = cim;
			Kategoria = kategoria;
			KiadasiEv = kiadasiEv;
		}

		public void Kolcsonzes()
		{
			
		}
		public void Visszavetel()
		{

		}

	}
}
