//using challenges.Data_Structures.Trees.MirrorTree;

//namespace MirrorTreeTest
//{
//    public class UnitTest1
//    {
//        [Fact]
//        public void MirrorTreeTestWithInOrderTraversal()
//        {

//            // Arrange
//            MirrorTree tree = new MirrorTree();
//            tree.Add(4);
//            tree.Add(8);
//            tree.Add(7);
//            tree.Add(12);
//            tree.Add(9);

//            // Act
//            List<int> originalInorder = tree.InorderTraversal();
//            tree.Mirror();
//            List<int> mirroredInorder = tree.InorderTraversal();

//            // Assert
//            Assert.Equal(new List<int> { 4, 7, 8, 9, 12 }, originalInorder);
//            Assert.Equal(new List<int> { 12, 9, 8, 7, 4 }, mirroredInorder);



//        }


//        [Fact]
//        public void SingleNodeTreeTest()
//        {

//            // Arrange
//            MirrorTree tree = new MirrorTree();
//            tree.Add(4);
          

//            // Act
//            List<int> originalInorder = tree.InorderTraversal();
//            tree.Mirror();
//            List<int> mirroredInorder = tree.InorderTraversal();

//            // Assert
//            Assert.Equal(new List<int> { 4 }, originalInorder);
//            Assert.Equal(new List<int> { 4 }, mirroredInorder);



//        }

//        [Fact]
//        public void EmptyTreeTest()
//        {

//            // Arrange
//            MirrorTree tree = new MirrorTree();
            


//            // Act
//            List<int> originalInorder = tree.InorderTraversal();
//            tree.Mirror();
//            List<int> mirroredInorder = tree.InorderTraversal();

//            // Assert
//            Assert.Equal(new List<int> {}, originalInorder);
//            Assert.Equal(new List<int> {}, mirroredInorder);



//        }
//    }
//}