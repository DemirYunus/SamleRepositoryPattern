using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Entities.Model
{
    //sealed inherite izin vermez
    public sealed class Product
    {
        public int ID_Product { get; set; }
        public int Product_Name { get; set; }
        public int Category_ID { get; set; }
    }
}
