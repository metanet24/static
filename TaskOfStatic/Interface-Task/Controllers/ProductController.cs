using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Task.Controllers
{
    public class ProductController
    {
        private readonly IProductService _productService;

        public ProductController()
        {
            _productService=new ProductService();
        }


        public void CountOfAllProduct()
        {
            var res=_productService.CountOfAllProducts();
            Console.WriteLine(res);
        }


        public void Search()
        {
            Console.WriteLine("Add txt");
            string txt = Console.ReadLine();
            var res = _productService.SearchByName(txt);
            foreach (var item in res)
            {
                Console.WriteLine(item.Name + " " + item.Price);
            }
        }

        public void SortByDate()
        {
            var res=_productService.SortByDate();

            foreach (var item in res)
            {
                Console.WriteLine(item.Name+" "+item.CreatedDate);
            }
        }

        public void Show()
        {
            var res=_productService.GetProducts();

            foreach (var item in res)
            {
                Console.WriteLine(item.Name+" "+ item.Category.Name);
            }
        }

        public void SearchCategory()
        {
            Console.WriteLine("Add txt");
            string txt = Console.ReadLine();
            var res = _productService.GetByCategory(txt);
            foreach (var item in res)
            {
                Console.WriteLine(item.Name + " " + item.Price);
            }

        }

        public void GetByCategoryId()
        {
            Console.WriteLine("Add id");
            int id=int.Parse(Console.ReadLine());
            var res=_productService.GetByCategoryId(id);

            foreach (var item in res)
            {
                Console.WriteLine(item.Name+" "+item.Category.Name);
            }

        }


        public void GetAll()
        {
            var res = _productService.GetProducts();

            foreach(var item in res)
            {
                Console.WriteLine(item.Name+" "+item.Category.Name+" "+item.Price);
            }
        }
    }
} 
