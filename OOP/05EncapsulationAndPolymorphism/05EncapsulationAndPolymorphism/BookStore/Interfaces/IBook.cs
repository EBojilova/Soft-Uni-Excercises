﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Interfaces
{
    interface IBook
    {
        string Title { get; }
        decimal Price { get; }
    }
}
