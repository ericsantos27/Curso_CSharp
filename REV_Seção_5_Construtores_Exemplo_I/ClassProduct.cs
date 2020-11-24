using System;
using System.Collections.Generic;
using System.Text;

namespace REV_Seção_5_Construtores_Exemplo_I
{
    class ClassProduct
    {
        public string ProductName;
        public double ProductPrice;
        public int ProductQty;

        public ClassProduct(string name, double price, int qty)
        {
            ProductName = name;
            ProductPrice = price;
            ProductQty = qty;
        }

        public double InventTotalValue()
        {
            return ProductPrice * ProductQty;
        }
        public void AddProdQty(int quantity)
        {
            ProductQty += quantity;
        }
        public void DedProdQty(int quantity)
        {
            ProductQty -= quantity;
        }

        public override string ToString()
        {
            return ProductName + ", " + ProductQty + " unidades," + " Total: $ " + InventTotalValue();
        }
    }
}
