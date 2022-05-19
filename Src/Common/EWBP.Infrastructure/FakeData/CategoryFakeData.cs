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

    public class CategoryFakeData : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(

             new Category { Id = 1, Name = "Teknology", CreateDate = DateTime.Now, Status = Status.Active },
             new Category { Id = 2, Name = "Vacuum Flasks & Mugs", CreateDate = DateTime.Now, Status = Status.Active },
             new Category { Id = 3, Name = "Sneakers", CreateDate = DateTime.Now, Status = Status.Active },
             new Category { Id = 4, Name = "Cordless Drills", CreateDate = DateTime.Now, Status = Status.Active }

           

             );
        }
    }
}
