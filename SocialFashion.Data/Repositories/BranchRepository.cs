using SocialFashion.Data.Infrastructure;
using SocialFashion.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialFashion.Data.Repositories
{
    public interface IBranchRepository : IRepository<Branch>
    {
    }
    public class BranchRepository : RepositoryBase<Branch>, IBranchRepository
    {
        public BranchRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
