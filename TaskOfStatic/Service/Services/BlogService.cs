using Domain.Models;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class BlogService : IBlogService
    {
        private Blog[] Blogs()
        {
            return new Blog[]
            {
                new Blog{Id=1,Title="My1",Description="Desc1"},
                 new Blog{Id=2,Title="My1",Description="Desc1"},
                  new Blog{Id=3,Title="My1",Description="Desc1"}
            };
        }
        public Blog[] GetBlogs()
        {
            return Blogs();
        }
        public Blog GetById(int id)
        {
            return Blogs().FirstOrDefault(m => m.Id == id);
        }
    }
}
