using challenges.Data_Structures.LinkedList;

namespace MergeSortedLinkedListsTest
{
    public class UnitTest1
    {
        [Fact]
        public void OneListIsEmpty()
        {
            // Arrange
            Linked_List list1 = new Linked_List();
            list1.AddEnd(1);
            list1.AddEnd(3);
            list1.AddEnd(5);

            Linked_List list2 = new Linked_List();

            // Act
            Linked_List mergedList = Linked_List.MergeSortedLists(list1, list2);

            // Assert
            Assert.NotNull(mergedList.Head);
            Assert.Equal(1, mergedList.Head.Data);
            Assert.Equal(3, mergedList.Head.Next.Data);
            Assert.Equal(5, mergedList.Head.Next.Next.Data);
            Assert.Null(mergedList.Head.Next.Next.Next);
        }

        [Fact]
        public void BothListsAreEmpty()
        {
            // Arrange
            Linked_List list1 = new Linked_List();
            Linked_List list2 = new Linked_List();

            // Act
            Linked_List mergedList = Linked_List.MergeSortedLists(list1, list2);

            // Assert
            Assert.Null(mergedList.Head);
        }

        [Fact]
        public void Merge()
        {
            // Arrange
            Linked_List list1 = new Linked_List();
            list1.AddEnd(5);
            list1.AddEnd(10);
            list1.AddEnd(15);

            Linked_List list2 = new Linked_List();
            list2.AddEnd(2);
            list2.AddEnd(3);
            list2.AddEnd(20);

            // Act
            Linked_List mergedList = Linked_List.MergeSortedLists(list1, list2);

            // Assert
            Node current = mergedList.Head;
            int[] expectedValues = { 2, 3, 5, 10, 15, 20 };
            foreach (int value in expectedValues)
            {
                Assert.NotNull(current);
                Assert.Equal(value, current.Data);
                current = current.Next;
            }
            Assert.Null(current);
        }
    }
}