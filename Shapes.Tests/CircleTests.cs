namespace Shapes.Tests
{
    [TestFixture]
    internal class CircleTests
    {
        [Test]
        public void TestCircleArea()
        {
            // Arrange
            Circle circle = new Circle(5);

            // Act
            double area = circle.CalculateArea();

            // Assert
            Assert.AreEqual(78.53981633974483, area, 0.00001);
        }

        [Test]
        public void TestCirclePerimeter()
        {
            // Arrange
            Circle circle = new Circle(5);

            // Act
            double perimeter = circle.CalculatePerimeter();

            // Assert
            Assert.AreEqual(31.41592653589793, perimeter, 0.00001);
        }
    }
}