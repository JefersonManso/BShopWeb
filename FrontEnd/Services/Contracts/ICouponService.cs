using BShop.Web.Models;

namespace BShop.Web.Services.Contracts;


public interface ICouponService
{
    Task<CouponViewModel> GetDiscountCoupon(string couponCode, string token);
}