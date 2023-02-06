using MindBox.Geometry.Exceptions;
using MindBox.Geometry.Figures;
using System.Threading;
using Xunit;

namespace Geometry.Tests.TriangleTests
{
    public class TriangleTest
    {
        [Fact]
        public void Triangle_Constructor_ThrowsTriangleArgumentException()
        {
            // Arrange
            double firstSide = -6;
            double secondSide = 0;
            double thirdSide = 10;
            Figure triangle;

            //Act & Assert
            Assert.Throws<TriangleArgumentException>(() => triangle = new Triangle(firstSide, secondSide, thirdSide));
        }

        [Fact]
        public void Triangle_GetArea_TrueAnswer()
        {
            // Arrange
            double firstSide = 2;
            double secondSide = 2;
            double thirdSide = 3;

            Figure circle = new Triangle(firstSide,secondSide,thirdSide);

            // Act
            double result = circle.GetArea();

            // Assert
            Assert.Equal(1.984313483298443, result);
        }

        [Fact]
        public async void Circle_GetAreaAsync_TrueAnswer()
        {
            // Arrange
            double firstSide = 2;
            double secondSide = 2;
            double thirdSide = 3;
            Figure triangle = new Triangle(firstSide,secondSide,thirdSide);
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            // Act
            double result = await triangle.GetAreaAsync(cancellationTokenSource.Token);

            // Assert
            Assert.Equal(1.984313483298443, result);
        }

        [Fact]
        public void Triangle_IsRectangular()
        {
            // Arrange
            double firstSide = 6;
            double secondSide = 8;
            double thirdSide = 10;
            Triangle triangle = new Triangle(firstSide,secondSide,thirdSide);
            // Act
            bool result = triangle.IsRectangular;
            // Assert
            Assert.True(result);
        }
    }
}
