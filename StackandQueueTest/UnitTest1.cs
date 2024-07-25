using challenges.Data_Structures.StackandQueue;

namespace StackandQueueTest
{
    public class UnitTest1
    {
        [Fact]
        public void PushingTest()
        {
            // Arrange
            StructureAsStack stack = new StructureAsStack();


            // Act
          stack.Push(1);
          var result = stack.Peek();

              // Assert
            Assert.Equal(1, result);

        }


        [Fact]
        public void poppingTest()
        {
            // Arrange
            StructureAsStack stack = new StructureAsStack();


            // Act
            stack.Push(1);
            stack.Push(2);
            stack.Pop();
            var result = stack.Peek();

            // Assert
            Assert.Equal(1, result);

        }


        [Fact]
        public void IsEmptyStackTest()
        {
            // Arrange
            StructureAsStack stack = new StructureAsStack();


            // Act
            var result = stack.IsEmpty();

            // Assert
            Assert.Equal(true, result);

        }



        [Fact]
        public void EnqueuingTest()
        {
            // Arrange
            StructureAsQueue queue = new StructureAsQueue();


            // Act
            queue.Enqueue(1);
            var result = queue.Peek();

            // Assert
            Assert.Equal(1, result);

        }


        [Fact]
        public void DequeuingTest()
        {
            // Arrange
            StructureAsQueue queue = new StructureAsQueue();


            // Act
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Dequeue();
            var result = queue.Peek();

            // Assert
            Assert.Equal(2, result);

        }


        [Fact]
        public void IsEmptyQueueTest()
        {
            // Arrange
            StructureAsQueue queue = new StructureAsQueue();


            // Act
            var result = queue.IsEmpty();

            // Assert
            Assert.Equal(true, result);

        }
    }
}