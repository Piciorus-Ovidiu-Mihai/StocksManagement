﻿using AutoMapper;
using StocksManagement.Domain.Entities;
using StocksManagement.Domain.Models.Product.Request;
using StocksManagement.Domain.Models.Storage.Request;

namespace StocksManagement.Infrastructure.Mapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Product, ProductCreateRequest>();
            CreateMap<ProductCreateRequest, Product>();
            CreateMap<Product, ProductUpdateRequest>();
            CreateMap<ProductUpdateRequest, Product>();
        }
    }
}