using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Task
{
    public class ProductFormViewModel : BaseModel
    {
        public Product Product { get; set; }

        public bool Validate()
        {
            return Product.Name != null &&
                Product.Name.Length > 4 &&
                Product.Price > -1 &&
                Product.Quantity > -1;
        }

    }
}
