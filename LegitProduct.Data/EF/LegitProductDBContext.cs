using LegitProduct.Data.Configurations;
using LegitProduct.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace LegitProduct.Data.EF
{
    public class LegitProductDBContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public LegitProductDBContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure using Fluent API
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserAddressConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserStoreConfiguration());
            modelBuilder.ApplyConfiguration(new AttributeConfiguration());
            modelBuilder.ApplyConfiguration(new AttributeValueConfiguration());
            modelBuilder.ApplyConfiguration(new BranchConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CollectionConfiguration());
            modelBuilder.ApplyConfiguration(new CollectionProductConfiguration());
            modelBuilder.ApplyConfiguration(new FavoriteConfiguration());
            modelBuilder.ApplyConfiguration(new LocationDistrictConfiguration());
            modelBuilder.ApplyConfiguration(new LocationProvinceConfiguration());
            modelBuilder.ApplyConfiguration(new LocationVillageConfiguration());
            modelBuilder.ApplyConfiguration(new LocationWardConfiguration());
            modelBuilder.ApplyConfiguration(new LogConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new PostCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new PostCommentConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new PostTagConfiguration());
            modelBuilder.ApplyConfiguration(new ProductBranchConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductImageConfiguration());
            modelBuilder.ApplyConfiguration(new ProductPriceConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionProductConfiguration());
            modelBuilder.ApplyConfiguration(new RateConfiguration());
            modelBuilder.ApplyConfiguration(new StoresConfiguration());
            modelBuilder.ApplyConfiguration(new TagsConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

        }

        public  DbSet<AppConfig> AppConfigs { get; set; }
        public  DbSet<AppRole> AppRoles { get; set; }
        public  DbSet<AppUserAddress> AppUserAddresses { get; set; }
        public  DbSet<AppUserStore> AppUserStores { get; set; }
        public  DbSet<AppUser> AppUsers { get; set; }
        public  DbSet<AttributeValue> AttributeValues { get; set; }
        public  DbSet<Entities.Attribute> Attributes { get; set; }
        public  DbSet<Branch> Branches { get; set; }
        public  DbSet<Category> Categories { get; set; }
        public  DbSet<CollectionProduct> CollectionProducts { get; set; }
        public  DbSet<Collection> Collections { get; set; }
        public  DbSet<Favorite> Favorites { get; set; }
        public  DbSet<LocationDistrict> LocationDistrict { get; set; }
        public  DbSet<LocationProvince> LocationProvinces { get; set; }
        public  DbSet<LocationVillage> LocationVillage { get; set; }
        public  DbSet<LocationWard> LocationWard { get; set; }
        public  DbSet<Log> Logs { get; set; }
        public  DbSet<OrderDetail> OrderDetails { get; set; }
        public  DbSet<Order> Orders { get; set; }
        public  DbSet<PostCategory> PostCategories { get; set; }
        public  DbSet<PostComment> PostComments { get; set; }
        public  DbSet<PostTag> PostTags { get; set; }
        public  DbSet<Post> Posts { get; set; }
        public  DbSet<ProductBranch> ProductBranches { get; set; }
        public  DbSet<ProductCategory> ProductCategories { get; set; }
        public  DbSet<ProductImage> ProductImages { get; set; }
        public  DbSet<ProductPrice> ProductPrices { get; set; }
        public  DbSet<Product> Products { get; set; }
        public  DbSet<PromotionProduct> PromotionProducts { get; set; }
        public  DbSet<Promotion> Promotions { get; set; }
        public  DbSet<Rate> Rates { get; set; }
        public  DbSet<Store> Stores { get; set; }
        public  DbSet<Tag> Tags { get; set; }
        public  DbSet<Transaction> Transactions { get; set; }


    }
}
