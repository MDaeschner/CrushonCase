
using System;
using System.Collections.Generic;

namespace CrushonCase.Models
{
    public class Db
    {
        private static readonly Db _instance = new Db();
        
        private Db()
        {
            // Utilisateurs en base
            Users = new List<UserModel>();
            Users.Add(new UserModel() { Name = "SuperAdmin", Email = "superadmin@crushonapp.com", Role = "ADMIN" });
            Users.Add(new UserModel() { Name = "Friperie defaut 1", Email = "defretail@gmail.com", Role = "VENDEUR" });

            // Loggins
            Loggins = new List<LogginModel>();
            foreach(var user in Users)
            {
                Loggins.Add(new LogginModel() { Email = user.Email });
            }

            // Marques
            Brands = new List<BrandModel>();
            Brands.Add(new BrandModel() { Name = "Vert-Zache" });

            // Produits
            Products = new List<ProductModel>();
            Products.Add(new ProductModel() { Title = "Blouson Teddy", Price = 23.3M, Stock = 5 });

        }

        public static Db GetInstance()
        {
            return _instance;
        }

        // Loggin
        public List<LogginModel> Loggins { get; set; }
        // Utilisateurs
        public List<UserModel> Users { get; set; }
        // Marques
        public List<BrandModel> Brands { get; set; }
        // Produits
        public List<ProductModel> Products { get; set; }
    }
}
