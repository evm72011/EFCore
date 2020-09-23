using System.Collections.Generic;

namespace Rsvp.Models
{
    public class DataRepository: IRepository
    {
        private List<Product> data = new List<Product>();
        public List<Product> Products
        {
            get => data;
        }
        public void AddProduct(Product product)
        {

        }
    }
}