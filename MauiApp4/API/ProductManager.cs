using MauiApp4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp4.API
{
    public class ProductManager : IProductService
    {
        private HttpClient httpClient = new HttpClient();
        public async Task<List<Product>> GetAll()
        {
            return await httpClient.GetFromJsonAsync<List<Product>>("https://jsonplaceholder.typicode.com/todos");
        }

        public async Task<Product> GetById(int id)
        {
            return await httpClient.GetFromJsonAsync<Product>("https://jsonplaceholder.typicode.com/todos/"+id);
        }
    }
}
