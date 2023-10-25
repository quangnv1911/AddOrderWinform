using Lab_2.DTOs;
using Lab_2.Models;
using Lab_2.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Services.Services
{
    internal class SqlServerProductService : IProductService
    {
        NorthwindContext _context;
        public SqlServerProductService()
        {
             _context = new NorthwindContext();
        }

        public bool checkUnitInStock(int id, int quantity)
        {
            Product p = _context.Products
                .Where(p => p.ProductId == id)
                .FirstOrDefault();

            if( p != null)
            {
                if(p.UnitsInStock >= quantity)
                {
                    return true;
                }
            }
            
                return false;
            
        }

        public List<GetListProductDTO> getAllProduct()
        {
            return _context.Products
                .Select(p => new GetListProductDTO(p.ProductId, p.ProductName, p.UnitPrice, p.UnitsInStock))
                .ToList();
        }

        public decimal? getPriceById(int id)
        {
            Product p = _context.Products
                .Where(p => p.ProductId == id)
                .FirstOrDefault();
            if(p.UnitPrice != null)
            {
                return p.UnitPrice;
            }
            return 0;
                
        }

        public ProductOrderDTO getProductById(int id)
        {
            return (ProductOrderDTO)_context.Products
                .Where(p => p.ProductId == id)
                .Select(p => new ProductOrderDTO(p.ProductId, p.ProductName, 0))
                .FirstOrDefault(); 
        }
    }
}
