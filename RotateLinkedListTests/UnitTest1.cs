//using challenges.Data_Structures.LinkedList;
//using System.Collections.Generic;

//namespace RotateLinkedListTests
//{
//    public class UnitTest1
//    {
        
//        [Fact]
//        public void RotateLeft_K_Zero()
//        {
//            // Arrange
//            Linked_List list = new Linked_List();
//            list.AddFirst(1);
//            list.AddEnd(2);
//            list.AddEnd(3);
//            list.AddEnd(4);
//            list.AddEnd(5);

//            string expectedOutput = "1\r\n2\r\n3\r\n4\r\n5";
//            var consoleOutput = new System.IO.StringWriter();
//            Console.SetOut(consoleOutput);

//            // Act
//            list.RotateLeft(0);
//            list.PrintList();

//            // Assert
//            Assert.Equal(expectedOutput, consoleOutput.ToString().Trim());
//        }

//        [Fact]
//        public void RotateLeft_K_Greater_Than_Length()
//        {
//            // Arrange
//            Linked_List list = new Linked_List();
//            list.AddFirst(1);
//            list.AddEnd(2);
//            list.AddEnd(3);
//            list.AddEnd(4);
//            list.AddEnd(5);

//            int k = 7;  
//            string expectedOutput = "1\r\n2\r\n3\r\n4\r\n5"; 

//            var consoleOutput = new System.IO.StringWriter();
//            Console.SetOut(consoleOutput);

//            // Act
//            list.RotateLeft(k);
//            list.PrintList();

//            // Assert
//            Assert.Equal(expectedOutput, consoleOutput.ToString().Trim());
//        }
//    }
//}