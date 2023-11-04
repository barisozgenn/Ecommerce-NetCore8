using System;
using Entities.Concrete.Admin;
using Entities.Concrete.Product;
using Entities.Concrete.User;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class BarContextDb : DbContext //dbcontext inhereted 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("con_string_here");
        }

        #region Admin
        public DbSet<AdminUser>? AdminUsers { get; set; } /*variable name should be match with sql column name to connect them*/
        public DbSet<AdminRole>? AdminRoles { get; set; }
        public DbSet<AdminUserRole>? AdminUserRoles { get; set; }
        public DbSet<AdminEmailParameter>? AdminEmailParameters { get; set; }
        #endregion
        #region User
        public DbSet<User>? Users { get; set; } /*variable name should be match with sql column name to connect them*/
        public DbSet<UserDetail>? UserDetails { get; set; }
        public DbSet<UserAddress>? UserAddresses { get; set; }
        #endregion
        #region Product
        public DbSet<Product>? Products { get; set; }
        public DbSet<ProductCategory>? ProductCategories { get; set; }
        public DbSet<ProductOrder>? ProductOrders { get; set; }
        public DbSet<ProductOrderItem>? ProductOrderItems { get; set; }
        #endregion
    }
}

