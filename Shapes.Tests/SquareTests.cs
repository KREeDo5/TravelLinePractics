namespace Shapes.Tests
{
    [TestFixture]
    internal class SquareTests
    {
        [Test]
        public void TestSquareArea()
        {
            // Arrange
            Square square = new Square(5);

            // Act
            double area = square.CalculateArea();

            // Assert
            Assert.AreEqual(25, area);
        }

        [TestCase(10)]
        public void TestSquarePerimeter(double input)
        {
            // Arrange
            Square square = new Square(input);

            // Act
            double perimeter = square.CalculatePerimeter();

            // Assert
            Assert.AreEqual(40, perimeter);
        }
    }
}
