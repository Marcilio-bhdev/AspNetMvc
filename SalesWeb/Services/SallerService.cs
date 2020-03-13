using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWeb.Data;
using SalesWeb.Models;

namespace SalesWeb.Services
{
    public class SallerService
    {
        private readonly SalesWebContext _context;

        public SallerService(SalesWebContext context) 
        {
            _context = context;
        }

        public List<Saller> FindAll()
        {
            return _context.Seller.ToList();        
        }

    }
}
