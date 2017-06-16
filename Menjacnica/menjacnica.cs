using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menjacnica
{
	public class menjacnica
	{
		public ProvajderValute providerValuta = new ProvajderValute();

		public double Prodaj( double kolicina, string nazivValute )
		{
			Valuta zeljenaValuta = providerValuta.VratiValutu(nazivValute);

			return zeljenaValuta.ConvertTo(kolicina);
		}
		public double Kupi (double kolicina, string nazivValute)
		{
			Valuta zeljenaValuta = providerValuta.VratiValutu(nazivValute);
			return zeljenaValuta.ConvertFrom(kolicina);

		}
	}
}
