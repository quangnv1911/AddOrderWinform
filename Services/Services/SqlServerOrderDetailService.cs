using Lab_2.Models;
using Lab_2.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Services.Services
{
    internal class SqlServerOrderDetailService : IOrderDetailService
    {
        NorthwindContext _context;
        public SqlServerOrderDetailService()
        {
             _context = new NorthwindContext();
        }

        public void AddNewOrderDetail(OrderDetail orderDetail)
        {
            _context.Add(orderDetail);
            _context.SaveChanges();
        }
    }
}
