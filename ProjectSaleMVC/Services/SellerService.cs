using ProjectSaleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSaleMVC.Services
{
    public class SellerService
    {
        private readonly ProjectSaleMVCContext _context;

        //construtor
        public SellerService(ProjectSaleMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {            
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
