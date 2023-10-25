using Lab_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.DTOs
{
    public partial class GetListProductDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public decimal? UnitPrice { get; set; }

        public int? UnitStock { get; set; }

        public GetListProductDTO(int productID, string productName, decimal? unitPrice, int? unitStock)
        {
            ProductID = productID;
            ProductName = productName;
            UnitPrice = unitPrice;
            UnitStock = unitStock;
        }
        

        
    }
}
