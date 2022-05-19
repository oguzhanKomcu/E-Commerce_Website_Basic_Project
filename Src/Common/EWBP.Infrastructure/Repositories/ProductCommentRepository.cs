using EWBP.Domain.Models.Entities;
using EWBP.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWBP.Infrastructure.Repositories
{
    public class ProductCommentRepository : BaseRepository<Product_Comment>, IProductCommentRepository
    {
        public ProductCommentRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }
    }
}
