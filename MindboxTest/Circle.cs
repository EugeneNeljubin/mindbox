namespace MindboxTest
{
    class Circle : IFigure
    {
        private double _r;

        public Circle(double r)
        {
            _r = r;
        }

        public double Square ()
        {
            return _r * _r * 3.14;
        }
    }
}
