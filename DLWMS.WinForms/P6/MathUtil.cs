using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.P6
{
    public delegate int Operacija(int broj);

    public class MathUtil
    {
        public static int Calc(Operacija operacija, params int[] vrijednosti)
        {
            var suma = 0;
            for (int i = 0; i < vrijednosti.Length; i++)
                suma += operacija(vrijednosti[i]);
            return suma;
        }
        public static int CalcFunc(Func<int, int> operacija, params int[] vrijednosti)
        {
            var suma = 0;
            for (int i = 0; i < vrijednosti.Length; i++)
                suma += operacija(vrijednosti[i]);
            return suma;
        }
    }
}
