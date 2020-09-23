using System.Collections.Generic;

namespace Rsvp.Models
{
    public interface IRepository
    {
        List<Product> Products { get; }
        void AddProduct(Product product);
    }
}