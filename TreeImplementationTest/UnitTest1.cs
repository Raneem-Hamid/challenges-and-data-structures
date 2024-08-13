using challenges.Data_Structures.Trees;

namespace TreeImplementationTest
{
    public class UnitTest1
    {
        [Fact]
        public void AddingTest()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            // Act
            tree.Add(10);
            tree.Add(5);
            tree.Add(15);
            // Assert
            Assert.NotNull(tree.Root);
            Assert.Equal(10, tree.Root.Data);
            Assert.Equal(5, tree.Root.Left.Data);
            Assert.Equal(15, tree.Root.Right.Data);
        }


        [Fact]
        public void ContainsTest()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Add(10);
            tree.Add(5);
            tree.Add(15);


            // Act

            var TrueResult = tree.Contains(5);
            var FalseResult = tree.Contains(30);



            // Assert
            Assert.True(TrueResult);
            Assert.False(FalseResult);
        }



        [Fact]
        public void RemovingTest()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Add(10);
            tree.Add(5);
            tree.Add(15);


            // Act
            tree.Remove(5);
            var FalseResult = tree.Contains(5);


            // Assert
            
            Assert.False(FalseResult);
        }

        [Fact]
        public void PreOrderTest()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Add(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(3);
            tree.Add(7);

            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            tree.PreOrder(tree.Root);

            // Assert
            var expectedOutput = "10\r\n5\r\n3\r\n7\r\n15\r\n";
            Assert.Equal(expectedOutput, output.ToString());
        }


        [Fact]
        public void InOrderTest()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Add(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(3);
            tree.Add(7);

            // Capture the console output
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            tree.InOrder(tree.Root);

            // Assert
            var expectedOutput = "3\r\n5\r\n7\r\n10\r\n15\r\n";
            Assert.Equal(expectedOutput, output.ToString());
        }


        [Fact]
        public void PostOrderTest()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Add(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(3);
            tree.Add(7);

            // Capture the console output
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            tree.PostOrder(tree.Root);

            // Assert
            var expectedOutput = "3\r\n7\r\n5\r\n15\r\n10\r\n";
            Assert.Equal(expectedOutput, output.ToString());
        }
    }
}