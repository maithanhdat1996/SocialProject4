using SocialFashion.Data.Infrastructure;
using SocialFashion.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialFashion.Data.Repositories
{
   
    public interface IProductDetailRepository : IRepository<ProductDetail>
    {
    }
    public class ProductDetailRepository : RepositoryBase<ProductDetail>, IProductDetailRepository
    {
        public ProductDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
