using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videoteka
{
	internal class Felhasznalo
	{
		public string Nev { get; private set; }
		public List<Film> KikolcsonzottFilmek { get; private set; }

		public Felhasznalo(string nev)
		{
			Nev = nev;
		}
		public bool Kolcsonoz(Film film)
		{

		}

		public bool Visszaad(Film film)
		{

		}

	}
}
