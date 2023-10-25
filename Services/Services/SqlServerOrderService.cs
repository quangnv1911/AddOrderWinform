using Lab_2.Services.IServices;
using Lab_2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Services.Services
{
    internal class SqlServerOrderService : IOrderService
    {
        NorthwindContext _context;

        public SqlServerOrderService()
        {
            _context = new NorthwindContext();
        }

        public void AddNewOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public List<Order> GetOrders(int EmployeeId, string CustomerId, DateTime? FromDate, DateTime? ToDate, string? OrderByProperty)
        {
            List<Order> orders = _context.Orders
                .Where(p => (EmployeeId == 0 || p.EmployeeId == EmployeeId)
                    && (CustomerId.Equals(string.Empty) ||
                        (p.CustomerId != null && p.CustomerId.Equals(CustomerId)))
                    && (p.OrderDate >= FromDate && p.OrderDate <= ToDate)
                )
                .Include(o => o.Employee)
                .Include(o => o.Customer)
                .ToList();

            switch (OrderByProperty)
            {
                case "OrderId": orders.OrderBy(o => o.OrderId).ToList(); break;
                case "Customer": orders.OrderBy(o => o.CustomerId).ToList(); break;
                case "Employee": orders.OrderBy(o => o.EmployeeId).ToList(); break;
                case "OrderDate": orders.OrderBy(o => o.OrderDate).ToList(); break;
                case "Freight": orders.OrderBy(o => o.Freight).ToList(); break;
            }
            return orders;
        }
    }
}
