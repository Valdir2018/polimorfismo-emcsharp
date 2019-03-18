using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_resolucao_exc_polimorfismo_e_heranca.Entities
{
    class UsedProduct: Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(DateTime manufactureDate, string name, double price) : base (name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return Name+ "(used) $" + Price + "(Manufacture date:)" + ManufactureDate;
        }
    }
}
