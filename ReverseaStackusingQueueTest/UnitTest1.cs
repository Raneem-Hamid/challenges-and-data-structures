using challenges.Data_Structures.StackandQueue;
using challenges.Data_Structures.StackandQueue.ReverseStackUsingQueue;

namespace ReverseaStackusingQueueTest
{
    public class UnitTest1
    {
        [Fact]
        public void reversing_multiple_elements()
        {
            // Arrange
            StackWithReverse stack = new StackWithReverse();


            // Act
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.ReverseStack();
            var result = stack.Peek();

            // Assert
            Assert.Equal(1, result);

        }

        [Fact]
        public void reversing_one_element()
        {
            // Arrange
            StackWithReverse stack = new StackWithReverse();


            // Act
            stack.Push(1);
            stack.ReverseStack();
            var result = stack.Peek();

            // Assert
            Assert.Equal(1, result);

        }


        [Fact]
        public void IsEmptyStackTest()
        {
            // Arrange
            StackWithReverse stack = new StackWithReverse();


            // Act
            var result = stack.IsEmpty();

            // Assert
            Assert.Equal(true, result);

        }
    }
}