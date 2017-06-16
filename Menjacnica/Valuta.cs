using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
	public class Valuta
	{
		public double kurs;
		public string name;
		

		public Valuta( double kurs, string name)
		{
			this.kurs = kurs;
			this.name = name;

		}
		public double ConvertTo(double kolicina)
		{
			return kolicina * kurs;
		}

		public double ConvertFrom (double kolicina)
		{
			return kolicina / kurs;
		}

		

		



	}
}
