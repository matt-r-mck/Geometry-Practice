using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry_Practice {
    class Rectangle {

        private Quadrillateral quad = new Quadrillateral();

        public void GetPerimeter() {
            quad.GetPerimeter();
        }

        public void GetArea() {
            Console.WriteLine($"The Area of the Rectangle is {quad.Leg1 * quad.Leg2}");
        }

        public Rectangle(int l1, int l2) {
            quad.Leg1 = l1;
            quad.Leg2 = l1;
            quad.Leg3 = l2;
            quad.Leg4 = l2;
        }
    }
}
