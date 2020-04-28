using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace LegitProduct.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public AppUser()
        {
            AppUserAddresses = new HashSet<AppUserAddress>();
            AppUserStores = new HashSet<AppUserStore>();
            Favorites = new HashSet<Favorite>();
            Orders = new HashSet<Order>();
            Posts = new HashSet<Post>();
            Products = new HashSet<Product>();
            Rates = new HashSet<Rate>();
            Transactions = new HashSet<Transaction>();
        }
       
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string IdentityCard { get; set; }
        public int Glosbe { get; set; }
        public string EnReCertificate { get; set; }
        public string EnReCertificateImgPath { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int IsDeleted { get; set; }
        public string CreatedUserId { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual ICollection<AppUserAddress> AppUserAddresses { get; set; }
        public virtual ICollection<AppUserStore> AppUserStores { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Rate> Rates { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
