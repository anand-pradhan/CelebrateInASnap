using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CelebrateInASnap.Interfaces;
using CelebrateInASnap.Services;
using CelebrateInASnap.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CelebrateInASnap.Controllers
{
    public class PayPalController : Controller
    {
        private readonly IPayPalPaymentService _payPalPaymentService;
        private readonly ShoppingCart _shoppingCart;

        public PayPalController(IPayPalPaymentService payPalPaymentService, ShoppingCart shoppingCart)
        {
            _payPalPaymentService = payPalPaymentService;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreatePayment()
        {
            var payment = _payPalPaymentService.CreatePayment(GetBaseUrl(), "sale", _shoppingCart);

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
