using Domain.Data;
using Domain.Models;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _appDbContext;

        public ProductService()
        {
            _appDbContext = new AppDbContext();
        }

        private Product[] GetAll()
        {
            return new Product[]
            {
                new Product()
                {
                Id = 1,
                Name="Samsung",
                Price=2400,
                CreatedDate= new DateTime(2012,01,14),
                Category=new Category()
                {
                    Id=1,
                    Name="Phone",
                    CreatedDate = DateTime.Now,
                },
                },
                 new Product()
                {
                Id = 2,
                Name="LG",
                Price=4000,
                CreatedDate= new DateTime(2022,01,14),
                Category=new Category()
                {
                    Id=2,
                    Name="Tv",
                    CreatedDate = DateTime.Now,
                },
                },
                  new Product()
                {
                Id = 3,
                Name="PS",
                Price=1400,
             CreatedDate= new DateTime(2009,01,14),
                Category=new Category()
                {
                    Id=3,
                    Name="Game",
                    CreatedDate= DateTime.Now,
                }
                }
            };
        }
        public int CountOfAllProducts()
        {
            Product[] products = _appDbContext.GetProducts();

            var res = products.Count();

            return res;
        }

        public Product[] GetProducts()
        {
            Product[] products = _appDbContext.GetProducts();

            return products;
        }

        public Product[] SearchByName(string srchtxt)
        {
            var res= GetProducts();

            return res.Where(x=>x.Name.Trim().ToLower().Contains(srchtxt.Trim().ToLower())).ToArray();
        }

        public Product[] SortByDate()
        {
            return GetAll().OrderBy(m => m.CreatedDate).ToArray();
        }

        public double AvgPrice()
        {
            return GetProducts().Average(m => m.Price);
        }

        public Product[] GetByCategory(string categoryName)
        {
            var res = GetProducts();

            return res.Where(x => x.Category.Name==categoryName).ToArray();
        }

        public Product[] GetByCategoryId(int Id)
        {
            return GetProducts().Where(m => m.Category.Id == Id).ToArray();
        }
    }
}
