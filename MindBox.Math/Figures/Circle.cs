using MindBox.Geometry.Exceptions;

namespace MindBox.Geometry.Figures
{
    public class Circle : Figure
    {
        private double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new CircleArgumentException();
            _radius = radius;
        }
        
        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radius,2);
        }

        public override async Task<double> GetAreaAsync(CancellationToken cancellationToken)
        {            

            double result =  Math.PI* Math.Pow(_radius, 2);

            await Task.Delay(1);

            if (cancellationToken.IsCancellationRequested)
                cancellationToken.ThrowIfCancellationRequested();

            return result;
        }
    }
}
