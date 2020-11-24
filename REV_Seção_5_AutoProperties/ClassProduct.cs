using System;
using System.Collections.Generic;
using System.Text;

namespace REV_Seção_5_AutoProperties
{
    class ClassProduct
    {
        private double _price;
        public int Qty { get; private set; }
        public string Name { get; private set; }
        public ClassProduct(string name, double price, int qty)
        {
            Name = name;
            Qty = qty;
            _price = price;  
        }
        public double Price
        {
            get { return _price; }
            set
            {
                if(value <= 100.00)
                {
                    _price = value;
                }
            }
        }
        public double TotalInvent()
        {
            return _price * Qty;
        }
        public void AddQty(int prdQty)
        {
            Qty += prdQty;
        }
        public void RemQty(int prdQty)
        {
            Qty -= prdQty;
        }
        public override string ToString()
        {
            return "Produto: " + Name + "; Preço: $ " + _price + "; Quantidade: " + Qty + "; Total: $ " + TotalInvent();
        }
    }
}
