//using challenges.Data_Structures.StackandQueue.MinStack;

//namespace MinStackTest
//{
//    public class UnitTest1
//    {
//        [Fact]
//        public void GetMinTest()
//        {
//            // Arrange
//            var stack = new MinStack();
//            stack.Push(15);
//            stack.Push(7);
//            stack.Push(12);
//            stack.Push(3);


//            // Act
//            var result = stack.GetMin();

//            // Assert
//            Assert.Equal("3", result);
//        }



//        [Fact]
//        public void GetMinAfterPopingTest()
//        {
//            // Arrange
//            var stack = new MinStack();
//            stack.Push(15);
//            stack.Push(7);
//            stack.Push(12);
//            stack.Push(3);


//            // Act
//            var resultbefore = stack.GetMin();
//            stack.Pop();
//            var resultafter = stack.GetMin();

//            // Assert
//            Assert.Equal("3", resultbefore);
//            Assert.Equal("7", resultafter);
//        }

//        [Fact]
//        public void GetMinAfterPushingTest()
//        {
//            // Arrange
//            var stack = new MinStack();
//            stack.Push(15);
//            stack.Push(7);
//            stack.Push(12);
//            stack.Push(3);


//            // Act
//            var resultbefore = stack.GetMin();
//            stack.Push(2);
//            var resultafter = stack.GetMin();

//            // Assert
//            Assert.Equal("3", resultbefore);
//            Assert.Equal("2", resultafter);
//        }
//    }
//}