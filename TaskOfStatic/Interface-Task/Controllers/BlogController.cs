using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Task.Controllers
{
    public class BlogController
    {
        private readonly IBlogService _blogService;

        public BlogController()
        {
            _blogService = new BlogService();
        }

        public void GetAll()
        {
            var res=_blogService.GetBlogs();

            for (int i = 0; i < res.Length; i++)
            {
                string result = res[i].Id + " " + res[i].Title + " " + res[i].Description;
                Console.WriteLine(result);
            }
        }


        
    }
}
