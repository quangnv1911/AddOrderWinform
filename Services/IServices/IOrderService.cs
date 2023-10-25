using Lab_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Services.IServices
{
    public interface IOrderService
    {
        public List<Order> GetOrders(int EmployeeId, string CustomerId, DateTime? FromDate, 
            DateTime? ToDate, string? OrderByProperty);

        public void AddNewOrder(Order order);
    }
}
