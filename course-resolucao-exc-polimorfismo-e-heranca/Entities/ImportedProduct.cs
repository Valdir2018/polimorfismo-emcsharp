using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace course_resolucao_exc_polimorfismo_e_heranca.Entities
{
    class ImportedProduct :Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(double customFee, string name, double price) : base(name, price)
        {
            CustomFee = customFee;
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }
        public override  string priceTag()
        {
            return Name
                +  " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (CustomFee: $ "
                + CustomFee.ToString("F2", CultureInfo.InvariantCulture) 
                +")";
        }
    }
}
