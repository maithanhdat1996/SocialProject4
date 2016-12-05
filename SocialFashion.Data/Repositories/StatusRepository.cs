using SocialFashion.Data.Infrastructure;
using SocialFashion.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialFashion.Data.Repositories
{
    
    public interface IStatusRepository : IRepository<Status>
    {
    }
    public class StatusRepository : RepositoryBase<Status>, IStatusRepository
    {
        public StatusRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
