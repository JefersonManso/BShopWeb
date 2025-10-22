using BShop.DiscountApi.DTOs;

namespace BShop.DiscountApi.Repositories;

public interface ICouponRepository
{
    Task<CouponDTO> GetCouponByCode(string couponCode);
}
