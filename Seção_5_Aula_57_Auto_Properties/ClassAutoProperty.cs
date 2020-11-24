using System;
using System.Collections.Generic;
using System.Text;

/*
Em vez de usar a sintaxe básica de encapsulamento com underline e minúscula para encapsular e depois implementar 
o 'get' e o 'set', nos atributos 'prodPrice' e 'prodQty' vamos utilizar o conceito de auto-propertie com a configuração
do atributo e a implementação do 'get' e 'set' em uma mesma linha
*/
/* 
Apenas o atributo '_prodName' não poderá utilizar este recurso pq está utilizando uma regra custmizada para implementação
do 'set'
*/
/*
 Sequência sugerida de implementação de métodos de classe:
1. Atributos privativos
2. Propriedades auto implementadas
3. Construtores
4. Propriedades customizadas
5. Outros métodos da classe
*/
namespace Seção_5_Properties
{
    class ClassAutoProperty
    {
        /* 1. Atributos privativos */
        private string _propName;
        /* 2. Propriedades auto implementadas */
        public double PropPrice { get; private set; }
        public int PropQty { get; private set; }
        /* 3. Construtores */
        public ClassAutoProperty(string name, double price, int qty)
        {
            _propName = name;
            PropPrice = price;
            PropQty = qty;
        }
        /* 4. Propriedades customizadas */
        public string PropName
        {
            get { return _propName; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _propName = value;
                }
            }
        }

        /* 5. Outros métodos da classe */
        public double TotalInventValue()
        {
            return PropPrice * PropQty;
        }

        public void AddProdQty(int _prodQty)
        {
            PropQty += _prodQty;
        }

        public void RemProdQty(int _prodQty)
        {
            PropQty -= _prodQty;
        }

        public override string ToString()
        {
            return _propName + ", $ " + PropPrice.ToString("F2") + ", " + PropQty + " unidades, Total: $ "
            + TotalInventValue().ToString("F2");
        }
    }
}
