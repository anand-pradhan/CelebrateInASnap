﻿using CelebrateInASnap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelebrateInASnap.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> PreferredProducts { get; set; }
    }
}
