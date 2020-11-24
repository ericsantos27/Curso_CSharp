using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_4_Aula_42_Segundo_Problema_Exemplo
{
    class ProductClass
    {
        public string ProdName;
        public double ProdPrice;
        public int ProdQty;

        public double TotalInventValue()
        {
            return ProdPrice * ProdQty;
        }

        public void AddProdQty(int prodQty)
        {
            ProdQty += prodQty;
        }

        public void RemProdQty(int prodQty)
        {
            ProdQty -= prodQty;
        }

        public override string ToString()
        {
            return ProdName + ", $ " + ProdPrice.ToString("F2") + ", " + ProdQty + " unidades, Total: $ "
            + TotalInventValue().ToString("F2");
        }
    }
}
