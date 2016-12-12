using SocialFashion.Data.Infrastructure;
using SocialFashion.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace SocialFashion.Data.Repositories
{
    
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> TestGetAllProduct();
    }
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        private SocialFashionDbContext db = new SocialFashionDbContext();
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Product> TestGetAllProduct()
        {
            IEnumerable<GetAllProduct_Result> lstProductSp =  db.GetAllProduct().ToList();
            Mapper.CreateMap<Product, GetAllProduct_Result>().ReverseMap();
            IEnumerable<Product> listProduct = Mapper.Map<IEnumerable<Product>>(lstProductSp);
            return listProduct;
         }
    }
}
