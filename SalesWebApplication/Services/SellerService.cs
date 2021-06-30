using SalesWebApplication.Data;
using SalesWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebApplication.Services
{
    public class SellerService
    {
        private readonly SalesWebApplicationContext _context;

        public SellerService (SalesWebApplicationContext context)
        {
            _context = context;

        }

        public List<Seller> FindAll() {
           return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
          
        }

        public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(obj => obj.Id == id);
        }

        public void Revome(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }

    }
}
