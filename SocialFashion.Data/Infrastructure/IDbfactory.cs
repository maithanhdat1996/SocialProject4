using SocialFashion.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialFashion.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        SocialFashionDbContext Init();
    }
}
