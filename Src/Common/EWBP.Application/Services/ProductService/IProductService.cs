using EWBP.Application.Models.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWBP.Application.Services.ProductService
{
    public interface IProductService
    {
        Task<List<GetProductVM>> GetProducts();
    }
}
