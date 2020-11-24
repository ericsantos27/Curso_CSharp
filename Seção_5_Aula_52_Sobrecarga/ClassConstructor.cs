using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_4_Aula_42_Segundo_Problema_Exemplo
{
    class ClassProduct
    {
        public string ProdName;
        public double ProdPrice;
        public int ProdQty;

        /* Construtor - receber o nome da classe */
        public ClassProduct(string name, double price, int qty)
        {
            ProdName = name;
            ProdPrice = price;
            ProdQty = qty;
        }

        /* 2° Construtor - Sobrecarga  -> O argumento de quantidade para este construtor tem um valor fixo de 5 un */
        public ClassProduct(string name, double price)
        {
            ProdName = name;
            ProdPrice = price;
            ProdQty = 5;
        }

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
