using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_6_Aula_73_Modificador_Ref
{
    class ClassRef
    {
        public static void Triple (ref int x)
        {
            x = x * 3;
        } 
    }
}
