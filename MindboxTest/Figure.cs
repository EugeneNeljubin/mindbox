namespace MindboxTest
{
    class Figure : IFigure
    {
        private IFigure _figure;

        public Figure (double[] vars)
        {
            switch (vars.Length)
            {
                case 1: //круг по радиусу
                    _figure = new Circle(vars[0]);
                    break;
                case 2: //треугольник прямоугольный по 2 параметрам
                    _figure = new Triangle(vars[0], vars[0], vars[1]);
                    break;
                case 3: //треугольник по 3 сторонам
                    _figure = new Triangle(vars[0], vars[1], vars[2]);
                    break;
            }
        }
        public double Square() {
            return _figure.Square();   
        }
    }
}
