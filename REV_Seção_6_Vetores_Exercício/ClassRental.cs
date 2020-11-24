using System;
using System.Collections.Generic;
using System.Text;

namespace REV_Seção_6_Vetores_Exercício
{
    class ClassRental
    {
        public string TenName;
        public string TenEmail;

        public ClassRental(string name, string email)
        {
            TenName = name;
            TenEmail = email;
        }

        public override string ToString()
        {
            return TenName + "; " + TenEmail;
        }
    }
}
