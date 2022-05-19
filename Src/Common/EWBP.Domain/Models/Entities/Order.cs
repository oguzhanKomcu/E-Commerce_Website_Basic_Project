using EWBP.Domain.Enums;
using EWBP.Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWBP.Domain.Models.Entities
{
    public class Order : IBaseEntity
    {
        public int Id { get; set; }
        public int AppUser_Id { get; set; }
        public AppUser AppUser { get; set; }
        public int Amount { get; set; }

        public string Shipping_Address { get; set; }
        public string Order_Address { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }
        public List<Order_Detail> Order_Details { get; set; }
    }
}
