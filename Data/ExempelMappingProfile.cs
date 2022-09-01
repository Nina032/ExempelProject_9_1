using AutoMapper;
using ExempelProject.Data.Entities;
using ExempelProject.ViewModels;

namespace ExempelProject.Data
{
    public class ExempelMappingProfile : Profile
    {
        public ExempelMappingProfile()
        {
            CreateMap<Order, OrderViewModel>()
                .ForMember ( o => o.OrderId, ex=> ex.MapFrom( o=> o.Id))
                .ReverseMap();

            CreateMap<OrderItem, OrderItemViewModel>()
                .ReverseMap();
        }
    }
}
