using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_6_Aula_73_Modificador_Out
{
    class ClassOut
    {
        public static void Triple(int orign, out int result)
        {
            result = orign * 3;
        }
    }
}
