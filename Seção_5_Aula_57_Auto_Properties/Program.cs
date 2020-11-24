using System;

namespace Seção_5_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassAutoProperty propertiesProd = new ClassAutoProperty("Television", 950.00, 10);

            Console.WriteLine(propertiesProd.PropName);

            propertiesProd.PropName = "Television 4k";

            Console.WriteLine(propertiesProd.PropName);

            Console.WriteLine(propertiesProd.PropPrice);

            Console.WriteLine(propertiesProd.PropQty);
        }
    }
}
