namespace Shapes.Tests
{
    [TestFixture]
    internal class TriangleTests
    {
        [Test]
        public void TestTriangleArea()
        {
            // Arrange
            Triangle triangle = new Triangle(5, 7, 8);

            // Act
            double area = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(17.32050807568877, area, 0.00001);
        }

        [Test]
        public void TestTrianglePerimeter()
        {
            // Arrange
            Triangle triangle = new Triangle(5, 7, 8);

            // Act
            double perimeter = triangle.CalculatePerimeter();

            // Assert
            Assert.AreEqual(20, perimeter, 0.00001);
        }
    }
}
