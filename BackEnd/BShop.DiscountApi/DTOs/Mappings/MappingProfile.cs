using AutoMapper;
using BShop.DiscountApi.Models;

namespace BShop.DiscountApi.DTOs.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CouponDTO, Coupon>().ReverseMap();
    }
}