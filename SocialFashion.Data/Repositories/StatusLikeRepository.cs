using SocialFashion.Data.Infrastructure;
using SocialFashion.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialFashion.Data.Repositories
{

    public interface IStatusLikeRepository : IRepository<StatusLike>
    {
    }
    public class StatusLikeRepository : RepositoryBase<StatusLike>, IStatusLikeRepository
    {
        public StatusLikeRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
