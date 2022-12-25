using AutoMapper;
using Core.Data.Models;
using Core6.Models;

namespace Core.Domain.Common
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            //CreateMap<Customer, CustomerModel>().ForMember(d => d.CustomerId, m => m.MapFrom(s =>
            //s.CustomerId))
            //.ForMember(d => d.AccountNumber, m => m.MapFrom(s =>
            //s.AccountNumber))
            //.ForMember(d => d.PersonId, m => m.MapFrom(s =>
            //s.PersonId))      ;

            //CreateMap<Customer, CustomerModel>().ForMember(d => d.CustomerId, m => m.MapFrom(s =>
            // s.CustomerId))
            // .ForMember(d => d.AccountNumber, m => m.MapFrom(s =>
            // s.AccountNumber))
            // .ForMember(d => d.PersonId, m => m.MapFrom(s =>
            // s.PersonId)).ReverseMap();

            CreateMap<Customer, CustomerModel>();

            CreateMap<Customer, CustomerModel>().ReverseMap();
        }
        
    }
}
