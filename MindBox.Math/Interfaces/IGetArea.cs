namespace MindBox.Geometry.Interfaces
{
    internal interface IGetArea
    {
        public abstract double GetArea();

        public abstract Task<double> GetAreaAsync(CancellationToken cancellationToken);
        
    }
}
