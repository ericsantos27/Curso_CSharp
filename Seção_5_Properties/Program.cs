using System;

namespace Seção_5_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassProdProperty propertiesProd = new ClassProdProperty("Television", 950.00, 10);

            Console.WriteLine(propertiesProd.propName);
            
            propertiesProd.propName = "Television 4k";

            Console.WriteLine(propertiesProd.propName);

            Console.WriteLine(propertiesProd.propPrice);

            Console.WriteLine(propertiesProd.propQty);
        }
    }
}
