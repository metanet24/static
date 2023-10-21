using Domain.Data;
using Services.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service 
{
    public class ProductsService:IProductService
    {
        private readonly AppDbContext _Context;

        public ProductsService()
        {
            _Context = new AppDbContext();
        }

        public int GetCount()
        {
           var products =_Context.Products;
            return products.Length;
        }
    }
}
