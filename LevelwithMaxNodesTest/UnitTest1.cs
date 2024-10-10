using challenges.Data_Structures.LinkedList;
using challenges.Data_Structures.Trees;

namespace LevelwithMaxNodesTest
{
    public class UnitTest1
    {
        [Fact]
        public void FindMaxLevelNodes_CorrectLevelForExampleTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Add(50);
            Btree.Add(30);
            Btree.Add(70);
            Btree.Add(20);
            Btree.Add(40);
            Btree.Add(60);
            Btree.Add(80);

            // Act
            int maxLevel = Btree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(2, maxLevel); 
        }

        [Fact]
        public void FindMaxLevelNodes_MultipleLevelsSameMax()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Add(1);
            Btree.Add(2);
            Btree.Add(3);
            Btree.Add(4);
            Btree.Add(5);
            Btree.Add(6);
            Btree.Add(7);
            Btree.Add(8);
            Btree.Add(9);
            Btree.Add(100);
        

            // Act
            int maxLevel = Btree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(0, maxLevel); 
        }

        [Fact]
        public void FindMaxLevelNodes_EmptyTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => Btree.FindMaxLevelNodes());
        }
    }
}