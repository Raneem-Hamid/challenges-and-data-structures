using challenges.Data_Structures.Trees;

namespace MinimumDepthTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestMinimumDepth_MultipleNodes_VaryingDepths()
        {
            // Arrange
            BinarySearchTree Btree = new BinarySearchTree();
            Btree.Root = new TNode(1);
            Btree.Root.Left = new TNode(2);
            Btree.Root.Right = new TNode(3);
            Btree.Root.Left.Left = new TNode(4);
            Btree.Root.Left.Right = new TNode(5);

            // Act
            int minDepth = Btree.FindMinimumDepth();

            // Assert
            Assert.Equal(2, minDepth); 
        }

        [Fact]
        public void TestMinimumDepth_EmptyTree()
        {
            // Arrange
            BinarySearchTree Btree = new BinarySearchTree();

            // Act
            int minDepth = Btree.FindMinimumDepth();

            // Assert
            Assert.Equal(0, minDepth); 
        }
    }
}