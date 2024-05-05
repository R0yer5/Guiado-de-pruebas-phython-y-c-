using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace MCD
{
    public class MCD
    {
        public int CalcularMCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public int CalcularMCD_CuatroNumeros(int num1, int num2, int num3, int num4)
        {
            int mcd1 = CalcularMCD(num1, num2);
            int mcd2 = CalcularMCD(num3, num4);
            return CalcularMCD(mcd1, mcd2);
        }
    }
}
