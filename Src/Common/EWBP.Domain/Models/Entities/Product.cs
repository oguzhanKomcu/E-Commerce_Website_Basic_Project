using EWBP.Domain.Enums;
using EWBP.Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWBP.Domain.Models.Entities
{
    public class Product : IBaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Dimension { get; set; }
        public string Color { get; set; }
        public string ImagePath { get; set; }
        public int Category_Id { get; set; }
        public Category Category { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }



        public List<Order_Detail> Order_Details { get; set; }
        public List<Product_Comment> Product_Comments { get; set; }

    }
}
