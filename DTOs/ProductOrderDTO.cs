using Lab_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.DTOs
{
    public partial class ProductOrderDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public short Quantity { get; set; }

        public ProductOrderDTO(int productID, string productName, short quantity)
        {
            ProductID = productID;
            ProductName = productName;
            Quantity = quantity;
        }
        

    }
}
