using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csApiLinq.DivisaoTryCatch
{
	internal static class Divisao2Numeros
	{
		public static double Dividir(int a, int b)
		{
			
			try
			{
				return a / b;
			}
			catch (DivideByZeroException ex)
			{
                Console.WriteLine(ex.Message);
				return 0;
            }
		}
	}
}