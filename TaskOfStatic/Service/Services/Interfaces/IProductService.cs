using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IProductService
    {
        Product[] GetProducts();

        int CountOfAllProducts();

        Product[] SearchByName( string srchtxt);

        Product[] SortByDate();

        double AvgPrice();

        Product[] GetByCategory( string categoryName);

        Product[] GetByCategoryId(int Id);
    }
}
