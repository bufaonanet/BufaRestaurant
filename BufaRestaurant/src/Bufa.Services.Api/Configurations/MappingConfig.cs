using AutoMapper;
using Bufa.Services.Api.Models;
using Bufa.Services.Api.Models.Dtos;

namespace Bufa.Services.Api.Configurations
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}