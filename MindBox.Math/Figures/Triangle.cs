
using MindBox.Geometry.Exceptions;

namespace MindBox.Geometry.Figures
{
    public class Triangle : Figure
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        private double _halfPerimeter;        

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                throw new TriangleArgumentException();

            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;

            _halfPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;
        }

        public bool IsRectangular
        {
            get
            {
                if ((_firstSide * _firstSide + _secondSide * _secondSide == _thirdSide * _thirdSide)
                    || (_firstSide * _firstSide + _thirdSide * _thirdSide == _secondSide * _secondSide)
                    || (_thirdSide * _thirdSide + _secondSide * _secondSide == _firstSide * _firstSide))
                    return true;

                return false;
            }
        }

        public override double GetArea() =>        
            Math.Sqrt(_halfPerimeter * (_halfPerimeter - _firstSide) * (_halfPerimeter - _secondSide) * (_halfPerimeter - _thirdSide));
        

        public override async Task<double> GetAreaAsync(CancellationToken cancellationToken)
        {
            double result = Math.Sqrt(_halfPerimeter * (_halfPerimeter - _firstSide) * (_halfPerimeter - _secondSide) * (_halfPerimeter - _thirdSide));           

            await Task.Delay(1);

            if (cancellationToken.IsCancellationRequested)
                cancellationToken.ThrowIfCancellationRequested();

            return result;
        }
    }
}
