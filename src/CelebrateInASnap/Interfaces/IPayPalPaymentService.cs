using CelebrateInASnap.Models;
using PayPal.Api;

namespace CelebrateInASnap.Interfaces
{
    public interface IPayPalPaymentService
    {
        Payment CreatePayment(string baseUrl, string intent, ShoppingCart shoppingCart);
        Payment ExecutePayment(string paymentId, string payerId);
    }
}
