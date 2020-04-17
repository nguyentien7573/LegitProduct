using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string Adress { get; set; }
        public string IdentityCard { get; set; }
        public int Glosbe { get; set; }
        public string EnReCertificate { get; set; }  //Enterprise Registration Certificate
        public string EnReCertificateImgPath { get; set;}
        public string StoreName { get; set;}
        public string StoreAdress { get; set; }
        public List<Order> Orders { get; set; }
        public List<Transaction> Transactions { get; set; }

       
    }
}
