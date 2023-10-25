using Lab_2.Models;
using Lab_2.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Services.Services
{
    internal class SqlServerCategoryService : ICategoryService
    {
        NorthwindContext _context;
        public SqlServerCategoryService()
        {
            _context = new NorthwindContext();
        }

       
    }
}
