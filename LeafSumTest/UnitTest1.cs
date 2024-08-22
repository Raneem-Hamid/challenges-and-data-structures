using challenges.Data_Structures.Trees.LeafSum;
using challenges.Data_Structures.Trees.SecondMaxValue;

namespace LeafSumTest
{
    public class UnitTest1
    {
        [Fact]
        public void GetLeafSumTest()
        {

            // Arrange
            var tree = new LeafSum();
            tree.Add(15);
            tree.Add(10);
            tree.Add(20);
            tree.Add(25);
            tree.Add(17);
            tree.Add(12);
            tree.Add(8);

            // Act
            int result = tree.GetLeafSum();

            // Assert
            Assert.Equal(62, result);
        }


        [Fact]
        public void GetLeafSumWithNegativeValuesTest()
        {

            // Arrange
            var tree = new LeafSum();
            tree.Add(-10);
            tree.Add(-5);
            tree.Add(-20);
            

            // Act
            int result = tree.GetLeafSum();

            // Assert
            Assert.Equal(-25, result);
        }
    }
}