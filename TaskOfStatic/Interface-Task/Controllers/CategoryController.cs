using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Task.Controllers
{
    public class CategoryController
    {
        private readonly ICategoryService _categoryService;

        public CategoryController()
        {
            _categoryService = new CategoryService();
        }

        public void GetAll()
        {
            var res= _categoryService.GetAll();

            foreach (var item in res)
            {
                Console.WriteLine(item.Name+" "+item.CreatedDate);
            }
        }
    }
}
