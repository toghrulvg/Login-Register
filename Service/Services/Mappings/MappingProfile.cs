﻿using AutoMapper;
using Domain.Entities;
using Service.Services.DTOs.Account;
using Service.Services.DTOs.Book;
using Service.Services.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<ProductCreateDto, Product>();
            CreateMap<Product, ProductListDto>();
            CreateMap<ProductUpdateDto, Product>().ReverseMap();

            CreateMap<BookCreateDto, Book>();
            CreateMap<Book, BookListDto>();
            CreateMap<BookUpdateDto, Book>().ReverseMap();

            CreateMap<RegisterDto, AppUser>().ReverseMap();
        }
    }
}
