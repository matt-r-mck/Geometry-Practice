﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry_Practice {
    class Quadrillateral {

        public int Leg1 { get; set; }
        public int Leg2 { get; set; }
        public int Leg3 { get; set; }
        public int Leg4 { get; set; }

        public void GetPerimeter() {
            Console.WriteLine($"The perimeter is {Leg1 + Leg2 + Leg3 + Leg4}");
        }

        public Quadrillateral() {

        }
    }
}
