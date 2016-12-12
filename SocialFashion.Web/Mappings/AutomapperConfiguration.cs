using AutoMapper;
using SocialFashion.Model.Models;
using SocialFashion.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialFashion.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Product, ProductViewModel>();

        }
    }
}