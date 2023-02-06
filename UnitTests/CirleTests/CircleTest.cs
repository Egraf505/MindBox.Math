using MindBox.Geometry.Exceptions;
using MindBox.Geometry.Figures;
using System.Threading;
using Xunit;

namespace Geometry.Tests.CirleTests
{
    public class CircleTest
    {
        [Fact]
        public void Circle_Constructor_ThrowsCircleArgumentException()
        {
            // Arrange
            double radius = -15;
            Figure circle;

            //Act & Assert
            Assert.Throws<CircleArgumentException>(() => circle = new Circle(radius));
        }

        [Fact]
        public void Circle_GetArea_TrueAnswer()
        {
            // Arrange
            double radius = 12;
            Figure circle = new Circle(radius);

            // Act
            double result = circle.GetArea();

            // Assert
            Assert.Equal(452.3893421169302, result);
        }

        [Fact]
        public async void Circle_GetAreaAsync_TrueAnswer()
        {
            // Arrange
            double radius = 12;
            Figure circle = new Circle(radius);
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();    

            // Act
            double result = await circle.GetAreaAsync(cancellationTokenSource.Token);

            // Assert
            Assert.Equal(452.3893421169302, result);
        }
    }

}
