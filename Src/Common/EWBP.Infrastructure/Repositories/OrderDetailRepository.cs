using EWBP.Domain.Models.Entities;
using EWBP.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWBP.Infrastructure.Repositories
{
    public class OrderDetailRepository : BaseRepository<Order_Detail>, IOrderDetailRepository
    {
        public OrderDetailRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }
    }
}
