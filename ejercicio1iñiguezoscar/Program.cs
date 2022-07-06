
using System;

namespace PSeInt
{
	class ejercio01iniguezoscar
	{

		static void Main(string[] args)
		{
			int dolarcompra;
			double eurocompra;
			int pesos;
			// ingresar las variables
			Console.Write(" ingrese la cantidad de pesos que tiene:");
			pesos = int.Parse(Console.ReadLine());
			// Proceso 
			dolarcompra = pesos * 230;
			eurocompra = dolarcompra * 1.17;
			// ingreso de informacion
			Console.WriteLine(" podemos comprar con pesos esta cantidad de doares:" + dolarcompra);
			Console.WriteLine("podes comprar con pesos esta cantidad de euros:" + eurocompra);
		}

	}

}

