using AutoMapper;
using BShop.DiscountApi.Context;
using BShop.DiscountApi.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BShop.DiscountApi.Repositories;

public class CouponRepository : ICouponRepository
{
    private readonly AppDbContext _context;
    private IMapper _mapper;

    public CouponRepository(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<CouponDTO> GetCouponByCode(string couponCode)
    {
        var coupon = await _context.Coupons.FirstOrDefaultAsync(c =>
                          c.CouponCode == couponCode);

        return _mapper.Map<CouponDTO>(coupon);
    }
}