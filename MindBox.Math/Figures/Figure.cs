using MindBox.Geometry.Interfaces;

namespace MindBox.Geometry.Figures
{
    public abstract class Figure : IGetArea
    {             
        public abstract double GetArea();
        public abstract Task<double> GetAreaAsync(CancellationToken cancellationToken);
    }
}
