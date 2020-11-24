using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_4_Aula_42_Segundo_Problema_Exemplo
{
    /* utilizar 'private' em vez de 'public' para tornar o atributo da classe privativo */
    /* padrão de nomes para variáveis de 'private' é utilizar underline e letra minúscula */
    class ClassProduct
    {
        private string _prodName;
        private double _prodPrice;
        private int _prodQty;

        public ClassProduct(string name, double price, int qty)
        {
            _prodName = name;
            _prodPrice = price;
            _prodQty = qty;
        }

        /* Utilizar "GET" e o nome do atributo para classes privativas */

        public string GetName()
        {
            return _prodName;
        }

        /* Utilizar "SET" para alterar o nome do produto */

        public void SetName(string newName)
        {
            _prodName = newName;
        }

        public double GetPrice()
        {
            return _prodPrice;
        }

        public int GetQty()
        {
            return _prodQty;
        }

        public double TotalInventValue()
        {
            return _prodPrice * _prodQty;
        }

        public void AddProdQty(int prodQty)
        {
            _prodQty += prodQty;
        }

        public void RemProdQty(int prodQty)
        {
            _prodQty -= prodQty;
        }

        public override string ToString()
        {
            return _prodName + ", $ " + _prodPrice.ToString("F2") + ", " + _prodQty + " unidades, Total: $ "
            + TotalInventValue().ToString("F2");
        }
    }
}
