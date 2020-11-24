using System;
using System.Collections.Generic;
using System.Text;

namespace REV_Seção_04_Aula_42
{
    class ClassProduct
    {
        public string ProductName;
        public double ProductPrice;
        public int ProductQty;

        public double TotalInventValue()
        {
            return ProductPrice * ProductQty;
        }
        public void AddQtyPrd(int qty)
        {
            ProductQty += qty;
        }
        public void RemQtyPrd(int qty)
        {
            ProductQty -= qty;
        }
        public override string ToString()
        {
            return ProductName + ", $ " + ProductPrice + ", " + ProductQty + " unidades. Total: $ " + TotalInventValue();
        }

    }
}
