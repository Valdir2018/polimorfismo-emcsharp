using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public override string priceTag()
        {
            return Name + "" +Price + "" + CustomFee;
        }
        public double totalPrice()
        {
            return Price + CustomFee;
        }
    }
}
