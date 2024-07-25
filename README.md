# challenges

## Challenge 01
CCA:ArrayReversal
function named ArrayReversal that accepts an array as its parameter.It return a new array where the elements are in the reverse order.  
 
[CC01.a whiteboard](challenges/whiteboard-challenges/ArrayReversal.png "Visit CC01.a")
 
CCB:Most Frequent Number
a method that takes an integer array and returns the number that appears the most times. If there are no duplicates, it returns the first number in the array. If more than one number shows up the same number of times, it returns the first found.  
 
[CC01.b whiteboard](challenges/whiteboard-challenges/MostFrequentNumber.png "Visit CC01.b")
 
## Challenge 02: Maximum Value
function called MaximumValue that accepts an array of integers as its parameter.The function should return the maximum value in the array.  
 
[CC2 whiteboard](challenges/whiteboard-challenges/MaximumValue.png "Visit CC02")

## Challenge 03: Remove Middle Value from Array  
A function called RemoveMiddleValue that takes in an array as its parameter.It should remove the value at the middle index of the array if the array length is odd, or the middle two values if the array length is even, and return the modified array.  
 
[CC03 whiteboard](challenges/whiteboard-challenges/RemoveMiddleValuefromArray.jpeg "Visit CC03")


## Challenge 04: Insert Middle Value into Array

A function called MiddleValue that takes in an array and a value to be added as its parameters. The function should insert the value at the middle index of the array. If the array length is even, the value should be inserted just before the midpoint. The function should return the modified array.

[CC04 whiteboard](challenges/whiteboard-challenges/InsertValueinMiddleofArray.png "Visit CC04")

## Challenge 05: Find Duplicates in Array

A function called FindDuplicates that takes in an array as its parameter. The function should return an array of duplicate values without utilizing any of the built-in methods provided by the language.

[CC05 whiteboard](challenges/whiteboard-challenges/FindDuplicates.png "Visit CC05")


## Challenge 06-A: Find Common Elements in Two Arrays 

A function called CommonElements that accepts two arrays of integers as its parameters. Without utilizing any of the built-in methods provided by the language, the function should return a new array containing the common elements between the two input arrays.

[CC06-A whiteboard](challenges/whiteboard-challenges/FindCommonElements-A.png "Visit CC06-A")

[CC06-A Output](challenges/Common-Elements/outputOfFindCommonElements-A.png "Visit CC06-A/output")


## Challenge 06-B: Reverse Words

A function called ReverseWords returns a string with the words in reverse order.

[CC06-B whiteboard](challenges/whiteboard-challenges/ReverseWords.png "Visit CC06-B")

[CC06-B Output](challenges/Reverse-Words/ReverseWordsOutput.png "Visit CC06-B/output")

## Data Structure 


### Linked List 

- Linked_List Class: Implements a singly linked list with methods to add, remove, print elements, and check for inclusion. 

[CC07 whiteboard](challenges/whiteboard-challenges/LinkedList.png "Visit CC07")

[CC07 Output](challenges/Data-Structures/LinkedList/LinkedListOutput.png "Visit CC07/output")


- RemoveDuplicate Method: This method iterates through the linked list and removes any nodes that contain duplicate data values. It returns the count of the duplicate nodes that were removed.

[CC07-B whiteboard](challenges/whiteboard-challenges/LinkedListRemoveDuplicates.png "Visit CC07")

[CC07-B Output](challenges/Data-Structures/LinkedList/RemoveDuplicates/LinkedListDuplicatesOutput.png "Visit CC07/output")

- MergeSortedLists Method: This method takes two sorted linked lists as inputs and merges them into a single sorted linked list. It uses two pointers to traverse both lists, compares the node values, and appends the smaller node to the merged list. It handles cases where one or both lists are empty, and ensures the resulting list is sorted.

[CC08 whiteboard](challenges/whiteboard-challenges/MergeSorted.png "Visit CC08")

[CC08 Output](challenges/Data-Structures/LinkedList/MergeSorted/MergeSortedOutput.png "Visit CC08/output")

[CC08 Test](MergeSortedLinkedListsTest/UnitTest1.cs)

### Stack and Queue Implementation

#### Stack Implementation

##### Stack Class

###### Push Method
This method adds a node with the specified data to the top of the stack. It creates a new node, sets its next reference to the current top, and updates the top to the new node.

###### Pop Method
This method removes and returns the top node from the stack. It checks if the stack is empty, throws an exception if it is, stores the top data, updates the top to the next node, and returns the stored data.

###### Peek Method
This method returns the top node from the stack without removing it. It checks if the stack is empty, throws an exception if it is, and returns the top data.

###### IsEmpty Method
This method checks if the stack is empty by returning whether the top is null.


#### Queue Implementation

##### Queue Class

###### Enqueue Method
This method adds a node with the specified data to the end of the queue. It creates a new node, sets it as both the front and back if the queue is empty, or appends it to the back and updates the back.

###### Dequeue Method
This method removes and returns the front node from the queue. It checks if the queue is empty, throws an exception if it is, stores the front data, updates the front to the next node, sets the back to null if the front becomes null, and returns the stored data.

###### Peek Method
This method returns the front node from the queue without removing it. It checks if the queue is empty, throws an exception if it is, and returns the front data.

###### IsEmpty Method
This method checks if the queue is empty by returning whether the front is null.


[whiteboard](challenges/whiteboard-challenges/StackandQueueImplementation.png "Visit CC09")

[Output](challenges/Data-Structures/StackandQueue/StackandQueueOutput.png "Visit CC09/output")

[Test](StackandQueueTest/UnitTest1.cs)


