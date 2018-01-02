using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelebrateInASnap.Interfaces
{
    public interface IPayPalPaymentService
    {
        Payment CreatePayment(string baseUrl, string intent);
        Payment ExecutePayment(string paymentId, string payerId);
    }
}
