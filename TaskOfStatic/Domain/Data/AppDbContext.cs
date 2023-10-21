using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data
{
    public class AppDbContext
    {
        public Category[] GetCategories()
        {
            return new Category[]
            {
                new Category(){Id=1,Name="Phone"},
                new Category(){Id=2,Name="Tv"},
                new Category(){Id=3,Name="Console"}
            };
        }

        public Product[] GetProducts()
        {
            return new Product[]
            {
                new Product()
                { 
                Id = 1,
                Name="Samsung",
                Price=2400,
                CreatedDate= new DateTime(2012,01,14),
                Category=GetCategories().FirstOrDefault(m=>m.Id==1)

                },
                 new Product()
                {
                Id = 2,
                Name="LG",
                Price=2400,
                CreatedDate= new DateTime(2010,01,14),
                Category=GetCategories().FirstOrDefault(m=>m.Id==3)

                },
                  new Product()
                {
                Id = 3,
                Name="PS5",
                Price=2400,
                CreatedDate= new DateTime(2011,01,14),
                Category=GetCategories().FirstOrDefault(m=>m.Id==3)

                }

            };
        }
    }
}
