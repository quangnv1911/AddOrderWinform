using Lab_2.DTOs;
using Lab_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Services.IServices
{
    public interface IProductService
    {
        public List<GetListProductDTO> getAllProduct();

        public ProductOrderDTO getProductById(int id);

        public decimal? getPriceById(int id);

        public bool checkUnitInStock(int id, int quantity);
    }
}
