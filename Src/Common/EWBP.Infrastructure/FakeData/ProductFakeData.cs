using EWBP.Domain.Enums;
using EWBP.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWBP.Infrastructure.FakeData
{


    public class ProductFakeData : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(

             new Product { Id = 1, Name = "iPhone 12", Description = "As part of our efforts to achieve our environmental goals, the iPhone 12 and iPhone 12 are not offered with a mini power adapter or EarPods. The box contains a USB-C - Lightning cable that supports fast charging, compatible with USB-C power adapters and computer ports.", Color = "Black", Price = 1100, Size = "146.7 x 71.5 x 7.4", ImagePath = "C:/ Users / Desktop / E - Commerce_Website / E - Commerce_Website_Basic_Project / Src / Web / EWBP.Presantation / wwwroot / Image / Product /iphone.jpg", Category_Id = 1, Stock= 300, CreateDate = DateTime.Now, Status = Status.Active },

             new Product { Id = 2, Name = "MSI Prestige 15", Description = "A11SCX-223TR Intel Core i7 1185G7 8GB 512GB SSD GTX1650 Windows 10 Home 15.6 FHD Laptop", Color = "Black", Price = 2000, Size = "15,6 inç", ImagePath = "C:/ Users / Desktop / E - Commerce_Website / E - Commerce_Website_Basic_Project / Src / Web / EWBP.Presantation / wwwroot / Image / Product /msi.jpg", Category_Id = 1, Stock = 150, CreateDate= DateTime.Now, Status = Status.Active },
           
             new Product { Id = 4, Name = "New STANLEY Classic Vacuum Insulated 750ml Bottle Thermos Flask", Description = "Boasting stainless steel vacuum insulation, this double walled Classic 750ml vacuum flask from Stanley is perfect for keeping hot drinks hot and cold drinks cold for up to 20 hours (04 days for ice).", Color = "Green", Price = 50, Size = "8.50cm Diameter - 30 cm Height", ImagePath = "C:/Users/Desktop/E-Commerce_Website/E-Commerce_Website_Basic_Project/Src/Web/EWBP.Presantation/wwwroot/Image/Product/stanley.jpg", Category_Id = 2, Stock = 250, CreateDate = DateTime.Now, Status = Status.Active },

             new Product { Id = 5, Name = "[New Balance] Retro 530 Silber SG Paar Laufschuhe Sportschuhe", Description = "New with box: A brand - new,unused,and unworn item(including handmade items) in the original packaging(such as the original box or bag) and / or with the original tags attached.", Color = "Black and White", Price = 104, Size =  "us5-us10", ImagePath = "C:/ Users / Desktop / E - Commerce_Website / E - Commerce_Website_Basic_Project / Src / Web / EWBP.Presantation / wwwroot / Image / Product /new-balance.png", Category_Id = 3, Stock = 80, CreateDate = DateTime.Now, Status = Status.Active },


             new Product { Id = 6, Name = "Bosch UniversalDrill ", Description = "Higher impact power and high performance in hard material with pneumatic mechanism", Color = "Green", Price = 110, Size = "30,3 x 22,8 x 9,1 cm", ImagePath = "C:/ Users / Desktop / E - Commerce_Website / E - Commerce_Website_Basic_Project / Src / Web / EWBP.Presantation / wwwroot / Image / Product /s-l1600.jpg", Category_Id = 4, Stock = 50, CreateDate = DateTime.Now, Status = Status.Active }



                );
        }
    }
}
