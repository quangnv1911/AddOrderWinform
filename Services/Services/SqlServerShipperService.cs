using Lab_2.Models;
using Lab_2.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Services.Services
{
    internal class SqlServerShipperService : IShipperService
    {
        NorthwindContext _context;

        public SqlServerShipperService()
        {
            _context = new NorthwindContext();
        }

        public List<Shipper> getAllShipper()
        {

            return _context.Shippers.ToList();
        }
    }
}
