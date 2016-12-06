﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SocialFashion.Model.Models
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class SocialFashionDbContext : IdentityDbContext<ApplicationUser>
    {
        public SocialFashionDbContext()
            : base("name=SocialFashionDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole>().HasKey(i => i.UserId);
            modelBuilder.Entity<IdentityUserLogin>().HasKey(i => i.UserId);
        }

        public static SocialFashionDbContext Create()
        {
            return new SocialFashionDbContext();
        }

        public virtual DbSet<Branch> Branchs { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Fan> Fans { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ProductDetail> ProductDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<StatusComment> StatusComments { get; set; }
        public virtual DbSet<StatusLike> StatusLikes { get; set; }
    }
}
