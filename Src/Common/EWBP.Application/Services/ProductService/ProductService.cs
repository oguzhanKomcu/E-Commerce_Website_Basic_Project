using AutoMapper;
using EWBP.Application.Models.VMs;
using EWBP.Domain.Enums;
using EWBP.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWBP.Application.Services.ProductService
{
    public  class ProductService : IProductService
    {

        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<GetProductVM>> GetProducts()
        {
            var products = await _productRepository.GetFilteredList(
              selector: x => new GetProductVM
              {
                  Id = x.Id,
                  Name = x.Name,
                  Description = x.Description,
                  Price = x.Price,
                  ImagePath = x.ImagePath,
                  CategoryName = x.Category.Name
              },
              expression: x => x.Status != Status.Passive,
              orderBy: x => x.OrderBy(x => x.Name),
              include: x => x.Include(x => x.Category));

            return products;
        }
    }
}
