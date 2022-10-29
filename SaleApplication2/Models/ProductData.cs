using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApplication2.Models
{
    class ProductData
    {
      public string Ad { get; set; }
        public int Cost { get; set; }
        public int Quantity{ get; set; }
        public int Summary { get; set; }


        public ProductData(string _ad, int _quantity, int _cost)
        {
            Ad = _ad;
            Cost = _cost;
            Quantity = _quantity;
            Summary = _cost * _quantity;
        }
    }
}
