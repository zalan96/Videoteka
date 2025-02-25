using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videoteka
{
	public class Videoteka 
	{
		public List<Film> Filmek { get; private set; }
		public List<Felhasznalo> Felhasznalok { get; private set; }

		public Videoteka()
		{
			Filmek = new List<Film>();
			Felhasznalok = new List<Felhasznalo>();
		}

		public void FilmHozzaadas(Film film)
		{
			Filmek.Add(film);
		}

		public void FelhasznaloHozzaadas(Felhasznalo felhasznalo)
		{
			Felhasznalok.Add(felhasznalo);
		}

		public Film KeresFilm(string cim)
		{
			return Filmek.Find(film.Cim == cim);
		}

		public Felhasznalo KeresFelhasznalo(string nev)
		{
			return Felhasznalok.Find(felhasznalo => felhasznalo.Nev == nev);
		}
	}
}
