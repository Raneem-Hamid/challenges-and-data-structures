using challenges.Data_Structures.Trees.SecondMaxValue;

namespace SecondMaxValueTest
{
    public class UnitTest1
    {
        [Fact]
        public void FindSecoondMaxValueTest()
        {
            // Arrange
            var tree = new SecondMaxValue();
            tree.Add(10);
            tree.Add(5);
            tree.Add(20);
            tree.Add(3);
            tree.Add(7);
            tree.Add(15);
            tree.Add(25);

            // Act
            int ? result = tree.GetSecondMax();

            // Assert
            Assert.Equal(20, result);
        }


        [Fact]
        public void FindSecondMaxValueWithOneNodeTest()
        {
            // Arrange
            var tree = new SecondMaxValue();
            tree.Add(10);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => tree.GetSecondMax());
        }

        // Test case for handling a tree with negative values.
        [Fact]
        public void FindSecondMaxValueWithNegativeValues()
        {
            // Arrange
            var tree = new SecondMaxValue();
            tree.Add(-10);
            tree.Add(-5);
            tree.Add(-20);
            tree.Add(-3);
            tree.Add(-7);
            tree.Add(-15);
            tree.Add(-25);

            // Act
            int? result = tree.GetSecondMax();

            // Assert
            Assert.Equal(-5, result);
        }

    }
}