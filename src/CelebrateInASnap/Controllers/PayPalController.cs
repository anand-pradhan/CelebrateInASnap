using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CelebrateInASnap.Interfaces;
using CelebrateInASnap.Services;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CelebrateInASnap.Controllers
{
    public class PayPalController : Controller
    {
        private readonly IPayPalPaymentService _payPalPaymentService;
        public PayPalController(IPayPalPaymentService payPalPaymentService)
        {
            _payPalPaymentService = payPalPaymentService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreatePayment()
        {
            var payment = _payPalPaymentService.CreatePayment(GetBaseUrl(), "sale");

            return Redirect(payment.GetApprovalUrl());
        }

        public IActionResult PaymentCancelled()
        {
            // TODO: Handle cancelled payment
            return RedirectToAction("Error");
        }

        public IActionResult PaymentSuccessful(string paymentId, string token, string PayerID)
        {
            // Execute Payment
            var payment = _payPalPaymentService.ExecutePayment(paymentId, PayerID);

            return View();
        }
        private string GetBaseUrl()
        {
            return Request.Scheme + "://" + Request.Host;
        }
    }
}
