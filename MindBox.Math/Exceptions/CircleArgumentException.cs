namespace MindBox.Geometry.Exceptions
{
    public class CircleArgumentException : Exception
    {
        public CircleArgumentException()
            :base("The radius is less than zero or equal to zero") {}
    }
}
