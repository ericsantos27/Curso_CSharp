using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_6_Aula_71_Exercício_Vetores
{
    class ClassTenant
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public ClassTenant(string tenName, string tenEmail)
        {
            Name = tenName;
            Email = tenEmail;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}
