using Microsoft.EntityFrameworkCore;
using Mission.Models;

namespace Mission.Data
{
    public static class ModelBuilderGenerator
    {
        public static void GenerateData(this ModelBuilder builder)
        {
            #region Données pour CATEGORIE
            builder.Entity<Categorie>().HasData(new Categorie() { Id = 1, Titre = "Vélos" });
            builder.Entity<Categorie>().HasData(new Categorie() { Id = 2, Titre = "Composantes" });
            builder.Entity<Categorie>().HasData(new Categorie() { Id = 3, Titre = "Vêtements" });
            builder.Entity<Categorie>().HasData(new Categorie() { Id = 4, Titre = "Accessoires" });
            #endregion

            #region Données pour PRODUIT
            builder.Entity<Produit>().HasData(new Produit() { Id = 1, Description = "Long-Sleeve Logo Jersey, S", DateCreation = DateTime.Now, PrixVente = 38, CategorieId = 3 });
            builder.Entity<Produit>().HasData(new Produit() { Id = 2, Description = "Long-Sleeve Logo Jersey, M", DateCreation = DateTime.Now, PrixVente = 38, CategorieId = 3 });
            builder.Entity<Produit>().HasData(new Produit() { Id = 3, Description = "HL Road Frame - Red, 62", DateCreation = DateTime.Now, PrixVente = 868, CategorieId = 1 });
            builder.Entity<Produit>().HasData(new Produit() { Id = 4, Description = "HL Road Frame - Red, 44", DateCreation = DateTime.Now, PrixVente = 870, CategorieId = 1 });
            builder.Entity<Produit>().HasData(new Produit() { Id = 5, Description = "LL Road Frame - Red, 44", DateCreation = DateTime.Now, PrixVente = 870, CategorieId = 1 });
            builder.Entity<Produit>().HasData(new Produit() { Id = 6, Description = "Road-150 Red, 62", DateCreation = DateTime.Now, PrixVente = 2171, CategorieId = 1 });
            builder.Entity<Produit>().HasData(new Produit() { Id = 7, Description = "Road-150 Red, 44", DateCreation = DateTime.Now, PrixVente = 2171, CategorieId = 1 });
            builder.Entity<Produit>().HasData(new Produit() { Id = 8, Description = "LL Headset", DateCreation = DateTime.Now, PrixVente = 16, CategorieId = 4 });
            builder.Entity<Produit>().HasData(new Produit() { Id = 9, Description = "LL Mountain Handlebars", DateCreation = DateTime.Now, PrixVente = 19, CategorieId = 2 });
            builder.Entity<Produit>().HasData(new Produit() { Id = 10, Description = "LL Mountain Front Wheel", DateCreation = DateTime.Now, PrixVente = 27, CategorieId = 2 });
            builder.Entity<Produit>().HasData(new Produit() { Id = 11, Description = "Classic Vest, M", DateCreation = DateTime.Now, PrixVente = 24, CategorieId = 3 });
            builder.Entity<Produit>().HasData(new Produit() { Id = 12, Description = "ML Road Seat/Saddle", DateCreation = DateTime.Now, PrixVente = 50, CategorieId = 4 });
            builder.Entity<Produit>().HasData(new Produit() { Id = 13, Description = "Mountain-500 Silver, 40", DateCreation = DateTime.Now, PrixVente = 308, CategorieId = 1 });
            builder.Entity<Produit>().HasData(new Produit() { Id = 14, Description = "Mountain-500 Silver, 42", DateCreation = DateTime.Now, PrixVente = 308, CategorieId = 1 });
            builder.Entity<Produit>().HasData(new Produit() { Id = 15, Description = "LL Bottom Bracket", DateCreation = DateTime.Now, PrixVente = 22, CategorieId = 4 });
            builder.Entity<Produit>().HasData(new Produit() { Id = 16, Description = "ML Bottom Bracket", DateCreation = DateTime.Now, PrixVente = 22, CategorieId = 4 });
            builder.Entity<Produit>().HasData(new Produit() { Id = 17, Description = "Rear Brakes", DateCreation = DateTime.Now, PrixVente = 47, CategorieId = 2 });
            builder.Entity<Produit>().HasData(new Produit() { Id = 18, Description = "Racing Socks, M", DateCreation = DateTime.Now, PrixVente = 4, CategorieId = 3 });
            builder.Entity<Produit>().HasData(new Produit() { Id = 19, Description = "Racing Socks, L", DateCreation = DateTime.Now, PrixVente = 4, CategorieId = 3 });
            builder.Entity<Produit>().HasData(new Produit() { Id = 20, Description = "Hydration Pack - 70 oz.", DateCreation = DateTime.Now, PrixVente = 21, CategorieId = 4 });
            #endregion

        }
    }
}
