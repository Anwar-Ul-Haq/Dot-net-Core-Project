using System.Collections.Generic;
using DutchTreat.Data.Entities;

namespace DutchTreat.Data
{
    public interface IDutchRepository
    {
        IEnumerable<Product> GetAllProcuts();
        IEnumerable<Product> GetProductsByCategory(string category);
        bool SaveAll();
    }
}