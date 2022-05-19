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

    public class AppUserFakeData : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasData(

             new AppUser {  First_Name = "Sezer", Last_Name="Turan", UserName= "sezer1" , Email="sezer@gmail.com" , PasswordHash="123", PhoneNumber="05345647541", CreateDate = DateTime.Now, Status = Status.Active },

              new AppUser { First_Name = "Batuhan", Last_Name = "Kara", UserName = "batuhan1", Email = "batuhan@gmail.com", PasswordHash = "123", PhoneNumber = "05345648996", CreateDate = DateTime.Now, Status = Status.Active },

               new AppUser { First_Name = "Furkan", Last_Name = "Yılmaz", UserName = "furkan1", Email = "furkan@gmail.com", PasswordHash = "123", PhoneNumber = "05345647848", CreateDate = DateTime.Now, Status = Status.Active },


                new AppUser { First_Name = "Ozan", Last_Name = "Eser", UserName = "ozan1", Email = "ozan@gmail.com", PasswordHash = "123",  PhoneNumber = "05345645623", CreateDate = DateTime.Now, Status = Status.Active }

                




                );
        }
    }
}
