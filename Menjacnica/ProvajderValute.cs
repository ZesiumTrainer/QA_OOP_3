using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menjacnica
{
	public class ProvajderValute
	{
		List<Valuta> listaValuta = new List<Valuta>();
		
		public void DodajValutu(Valuta v)
		{
			listaValuta.Add(v);

		}

		public Valuta VratiValutu ( string nazivValute)
		{
			foreach (Valuta v in listaValuta)
			{
				if ( v.name == nazivValute)
				{
					return v;
				}
			}

			return null;
		}
	}
}
