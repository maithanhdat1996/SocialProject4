
using SocialFashion.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialFashion.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private SocialFashionDbContext dbContext;

        public SocialFashionDbContext Init()
        {
            return dbContext ?? (dbContext = new SocialFashionDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }

        
    }
}
