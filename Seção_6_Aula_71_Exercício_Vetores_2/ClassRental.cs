using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_6_Aula_71_Exercício_Vetores_2
{
    class ClassRental
    {
        public string TenantName { get; set; }
        public string TenantEmail { get; set; }

       public ClassRental(string tenName, string tenEmail)
        {
            TenantName = tenName;
            TenantEmail = tenEmail;
        }

        public override string ToString()
        {
            return TenantName + ", " + TenantEmail;
        }
    }
}
