using SocialFashion.Data.Infrastructure;
using SocialFashion.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialFashion.Data.Repositories
{

    public interface IStatusCommentRepository : IRepository<StatusComment>
    {
    }
    public class StatusCommentRepository : RepositoryBase<StatusComment>, IStatusCommentRepository
    {
        public StatusCommentRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
