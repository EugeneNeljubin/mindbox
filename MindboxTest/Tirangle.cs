using System;

namespace MindboxTest
{
    class Triangle : IFigure
    {
        private double _a;
        private double _b;
        private double _c;

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public double Square ()
        {
            var _p = (_a + _b + _c) / 2;

            return Math.Sqrt(_p * (_p - _a) * (_p - _b) * (_p - _c));
        }
    }
}
