using challenges.Data_Structures.StackandQueue.DeleteMiddleElement;

namespace DeleteMiddleElementofaStackTest
{
    public class UnitTest1
    {
        [Fact]
        public void DeleteElementFromOddStack()
        {
            // Arrange
            var stack = new StackWithDeleteMiddle();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3); 
            stack.Push(4);
            stack.Push(5);

            // Act
            stack.DeleteMiddle();

            // Assert
            Assert.Equal(4, stack.Count()); 
        }



        [Fact]
        public void DeleteElementFromEvenStack()
        { // Arrange
            var stack = new StackWithDeleteMiddle();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4); 

            // Act
            stack.DeleteMiddle();

            // Assert
            Assert.Equal(3, stack.Count()); 
        }
    }
}