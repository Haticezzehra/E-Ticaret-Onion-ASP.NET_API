using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        => new() {
        new (){Id=Guid.NewGuid() ,Name="Product_1",Price=100, Stock=10},
        new (){Id=Guid.NewGuid() ,Name="Product_2",Price=100, Stock=10},
        new (){Id=Guid.NewGuid() ,Name="Product_3",Price=100, Stock=10},
        new (){Id=Guid.NewGuid() ,Name="Product_4",Price=100, Stock=10},
        new (){Id=Guid.NewGuid() ,Name="Product_5",Price=100, Stock=10},


        };
    }
}
