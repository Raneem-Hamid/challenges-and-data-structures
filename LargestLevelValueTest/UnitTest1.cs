using challenges.Data_Structures.Trees.LargestLevelValue;

namespace LargestLevelValueTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestLargestLevelValue()
        {

            // Arrange
            LargestLevelValue tree = new LargestLevelValue();
            tree.Add(15);
            tree.Add(10);
            tree.Add(20);
            tree.Add(25);
            tree.Add(17);
            tree.Add(12);
            tree.Add(8);

            // Act
            var result = tree.GetLargestLevelValue();

            // Assert
            List<int> expected = new List<int> { 15, 20, 25 };
            Assert.Equal(expected, result);

        }
    }
}