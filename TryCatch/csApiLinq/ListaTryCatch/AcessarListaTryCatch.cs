using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csApiLinq.ListaTryCatch
{
    internal static class AcessarListaTryCatch
    {
        public static List<int> inteiros = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7};

        public static int AcessarInteiro( int indice)
        {
            try
            {
                return inteiros[indice];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
