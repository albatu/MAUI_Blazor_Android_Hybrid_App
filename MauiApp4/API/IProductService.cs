using MauiApp4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp4.API
{
    public interface IProductService
    {
        Task<List<Product>> GetAll();
        Task<Product> GetById(int id); 

    }
}
