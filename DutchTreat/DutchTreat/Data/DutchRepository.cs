using DutchTreat.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace DutchTreat.Data
{
    public class DutchRepository : IDutchRepository
    {
        private readonly DutchContex _ctx;
        private readonly ILogger<DutchRepository> _logger;

        public DutchRepository(DutchContex ctx , ILogger<DutchRepository> logger) 
        {
            _ctx = ctx;
            _logger = logger;
        }

        public IEnumerable<Product> GetAllProcuts()
        {
            _logger.LogInformation("GetAllProducts was called");
            return _ctx.Products.OrderBy(p => p.Title).ToList();
        }


        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return _ctx.Products.Where(p => p.Category== category).ToList();
        }

        public bool SaveAll()
        {
            return _ctx.SaveChanges() > 0;
        }
    }

}
