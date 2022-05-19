using AutoMapper;
using EWBP.Application.Models.DTOs;
using EWBP.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWBP.Application.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {


            CreateMap<AppUser, RegisterDTO>().ReverseMap();
            CreateMap<AppUser, LoginDTO>().ReverseMap();
 
        }
    }
}
