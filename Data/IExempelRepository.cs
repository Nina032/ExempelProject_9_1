using System.Collections.Generic;
using ExempelProject.Data.Entities;

namespace ExempelProject.Data
{
    public interface IExempelRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(string category);

        IEnumerable<Order> GetAllOrders(bool includeItems);
        Order GetOrderById(int id);

        void AddEntity(object entity);
        bool SaveAll();
    }
}