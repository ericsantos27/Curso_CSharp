using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_5_Properties
{
    /* Encapsulamento dos atributos da classe com a declaração 'private' */
    class ClassProdProperty
    {
        private string _prodName;
        private double _prodPrice;
        private int _prodQty;

        /* Construtor da classe mapeando os parâmetros do construtor com os atributos da classe */
        public ClassProdProperty(string name, double price, int qty)
        {
            _prodName = name;
            _prodPrice = price;
            _prodQty = qty;
        }

        /* Proprerties dos atributos da classe com os métodos 'get' e 'set' */

        public string propName
        {
            get {return _prodName;}
            set
            {
                if (value != null && value.Length > 1)
                {
                    _prodName = value;
                }
            }
        }

        public double propPrice
        {
            get { return _prodPrice; }
        }
       
        public int propQty
        {
            get { return _prodQty; }
        }

        public double TotalInventValue()
        {
            return _prodPrice * _prodQty;
        }

        public void AddProdQty(int _prodQty)
        {
            _prodQty += _prodQty;
        }

        public void RemProdQty(int _prodQty)
        {
            _prodQty -= _prodQty;
        }

        public override string ToString()
        {
            return _prodName + ", $ " + _prodPrice.ToString("F2") + ", " + _prodQty + " unidades, Total: $ "
            + TotalInventValue().ToString("F2");
        }
    }
}


