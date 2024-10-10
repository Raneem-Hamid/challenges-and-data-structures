using challenges.Data_Structures.Trees;

namespace PrintRightViewTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test_RightView_MixedTree()
        {
            // Arrange
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(50);
            bst.Add(30);
            bst.Add(70);
            bst.Add(20);
            bst.Add(40);
            bst.Add(60);
            bst.Add(80);

            // Capture console output
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            bst.PrintRightView();

            // Assert
            var expectedOutput = "50 70 80 \r\n";
            Assert.Equal(expectedOutput, output.ToString());
        }

        [Fact]
        public void Test_RightView_RightOnlyTree()
        {
            // Arrange
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(20);
            bst.Add(30);
            bst.Add(40);
            bst.Add(50);

            // Capture console output
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            bst.PrintRightView();

            // Assert
            var expectedOutput = "10 20 30 40 50 \r\n";
            Assert.Equal(expectedOutput, output.ToString());
        }
    }
}