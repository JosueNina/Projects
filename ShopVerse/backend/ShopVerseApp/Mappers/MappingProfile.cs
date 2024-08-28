using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ShopVerseApp.DTOs.Product;
using ShopVerseApp.Models;

namespace ShopVerseApp.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateProductDto, Product>();
            CreateMap<Product, CreateProductDto>();
        }
    }
}