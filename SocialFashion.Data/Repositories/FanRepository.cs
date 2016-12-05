using SocialFashion.Data.Infrastructure;
using SocialFashion.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialFashion.Data.Repositories
{
    
    public interface IFanRepository : IRepository<Fan>
    {
    }
    public class FanRepository : RepositoryBase<Fan>, IFanRepository
    {
        public FanRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
