using challenges.Data_Structures.LinkedList;
using System.Collections.Generic;

namespace Linked_List_test
{
    public class UnitTest1
    {
        [Fact]
        public void RemoveEndItem_Test()
        {
            // Arrange
            var list = new Linked_List();
            list.AddEnd(1);
            list.AddEnd(2);
            list.AddEnd(3);

            // Act
            list.Remove(3);

            // Assert
            Assert.True(list.Include(1));
            Assert.True(list.Include(2));
            Assert.False(list.Include(3));

        }

        [Fact]
        public void PrintLinkedList_Test()
        {
            // Arrange
            var list = new Linked_List();
            list.AddFirst(1);
            list.AddEnd(2);
            list.AddEnd(3);

            // Act
            int printedList = list.PrintList();

            // Assert
            Assert.True(printedList >= 3);

        }
    }
}