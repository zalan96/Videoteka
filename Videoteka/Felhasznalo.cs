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
			if (KikolcsonzottFilmek.Count >= 3)
			{
				Console.WriteLine("Anna már 3 filmet kikölcsönzött, nem kérhet többet!");
				return false;
			}

			if (film.Kolcsonozve)
			{
				Console.WriteLine($"A(z) {film.Cim} című film már ki van kölcsönözve.");
				return false;
			}

			film.Kolcsonzes();
			KikolcsonzottFilmek.Add(film);
			Console.WriteLine($"A(z) {film.Cim} című filmet sikeresen kikölcsönözted.");
			return true;
		}

		public bool Visszaad(Film film)
		{
			if(!Kolcsonoz(film)) { return false; }
			return true;
		}
	} 
}
