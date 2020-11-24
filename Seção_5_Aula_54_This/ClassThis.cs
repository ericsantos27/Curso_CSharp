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

        /* Construtor - primeiro construtor */
        public ClassProduct()
        {
            ProdQty = 0;
        }

        /* 2° Construtor - Utilizando comando 'this' para reaproveitar o primeiro construtor */
        public ClassProduct(string name, double price) : this()
        {
            ProdName = name;
            ProdPrice = price;
        }

        /* 3° Construtor - Utilizando comando 'this'para reaproveitar o construtor com dois parâmetros */

        public ClassProduct(string name, double price, int qty) : this(name, price)
        {
            ProdQty = qty;
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
