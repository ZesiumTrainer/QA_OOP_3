using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menjacnica
{
	class Program
	{


		static void Main(string[] args)
		{
			Valuta dolar = new Valuta(110, "USA");
			Valuta euro = new Valuta(112, "EUR");
			Valuta jen = new Valuta(22, "JEN");
			
			menjacnica elDorado = new menjacnica();

			elDorado.providerValuta.DodajValutu(dolar);
			elDorado.providerValuta.DodajValutu(euro);
			elDorado.providerValuta.DodajValutu(jen);
			double prodaj;
			prodaj = elDorado.Prodaj(100, "EUR");

			
			


			Console.WriteLine("rezultat Vase prodaje je: " + prodaj);
			Console.ReadKey();
		}
	}
}
