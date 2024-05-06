﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Vector : IShape
    {
        public void Render(string shape)
        {
            Console.WriteLine($"Drawing {shape} as vector graphics");
        }
    }
}
