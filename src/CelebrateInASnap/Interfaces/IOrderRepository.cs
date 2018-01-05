using CelebrateInASnap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelebrateInASnap.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
