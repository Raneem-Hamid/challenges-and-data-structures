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

- RotateLeft Method: This method shifts the first k nodes of a singly linked list to the end, updating the head and tail pointers.

[whiteboard](challenges/whiteboard-challenges/LinkedList-RotatebyK.png "whiteboard")

[Output](challenges/Data-Structures/LinkedList/LinkedList-RotatebyK/LinkedList-RotatebyKOutput.png "output")

[Test](RotateLinkedListTests/UnitTest1.cs)

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

#### Reverse Stack Using Queue
A function called `ReverseStack` that takes in a stack and reverses its elements using a queue.

[whiteboard](challenges/whiteboard-challenges/ReverseaStackUsingQueue.png "Visit CC10")

[Output](challenges/Data-Structures/StackandQueue/ReverseStackUsingQueue/ReverseaStackUsingQueueOutput.png "Visit CC10/output")

[Test](ReverseaStackusingQueueTest/UnitTest1.cs)

#### Delete Middle Element of a Stack
A method called `DeleteMiddle` that takes in a stack and removes the middle element. If the stack has an even number of elements, it removes the lower middle element. The stack should remain in the correct order after the middle element is removed.

  
[whiteboard](challenges/whiteboard-challenges/DeleteMiddleElementofaStack.png "Visit CC11")

[Output](challenges/Data-Structures/StackandQueue/DeleteMiddleElement/DeleteMiddleElementofaStackOutput.png "Visit CC11/output")

[Test](DeleteMiddleElementofaStackTest/UnitTest1.cs)

#### Min Stack Challenge
A method `GetMin` that retrieves the minimum element in stack .
  
[whiteboard](challenges/whiteboard-challenges/MinStack.png "Visit CC11")

[Output](challenges/Data-Structures/StackandQueue/MinStack/MinStackOutput.png "Visit CC11/output")

[Test](MinStackTest/UnitTest1.cs)


### Tree Implementation

#### **Binary Tree Class**


###### **PreOrder Method**
This method performs a pre-order traversal of the binary tree. It processes the current node first, then recursively traverses the left subtree, followed by the right subtree.

###### **InOrder Method**
This method performs an in-order traversal of the binary tree. It recursively traverses the left subtree, processes the current node, and then traverses the right subtree.

###### **PostOrder Method**
This method performs a post-order traversal of the binary tree. It recursively traverses the left subtree, then the right subtree, and finally processes the current node.

###### **Print Method**
This method prints the binary tree in a structured format, showing the hierarchy of nodes with indentation to indicate levels and branches.

#### **Binary Search Tree Class**

###### **Add Method**
This method adds a node with the specified data to the binary search tree while maintaining the BST properties. It inserts the new node in the correct location based on its value.

###### **Contains Method**
This method checks whether a node with the specified data exists in the binary search tree. It returns `true` if the node is found, otherwise `false`.

###### **Remove Method**
This method removes a node with the specified data from the binary search tree while maintaining the BST properties. It handles nodes with no children, one child, or two children.

[whiteboard](challenges/whiteboard-challenges/TreeImplementation.png "Visit CC11")

[Output](challenges/Data-Structures/Trees/TreeImplementationOutput.png "Visit CC11/output")

[Test](TreeImplementationTest/UnitTest1.cs)

#### Mirror Tree Challenge
A method `Mirror()` that converts a binary tree into its mirror image, where the left and right children of all nodes are swapped.

[**Whiteboard**](challenges/whiteboard-challenges/MirrorTree.png "Visit Mirror Tree Whiteboard")

[**Output**](challenges/Data-Structures/Trees/MirrorTree/MirrorTreeOutput.png "Visit Mirror Tree Output")

[**Test**](MirrorTreeTest/UnitTest1.cs)


#### Second Maximum Value Challenge  
A method `FindSecondMax` that finds the second maximum value in a binary search tree. It starts by finding the rightmost node (maximum value) and then determines the second maximum based on the presence of a left subtree or by the parent node.  
[**Whiteboard**](challenges/whiteboard-challenges/SecondMaximumValue.png "Visit Second Max Value Whiteboard")  
[**Output**](challenges/Data-Structures/Trees/SecondMaxValue/SecondMaximumValueOutput.png "Visit Second Max Value Output")  
[**Test**](SecondMaxValueTest/UnitTest1.cs)

#### Sum of leaf Challenge  
A method `GetLeafSum()` that calculate the sum of all leaf nodes in a binary search tree. A leaf node is a node that does not have any children ( both left and right children are null).
[**Whiteboard**](challenges/whiteboard-challenges/Sumofleaf.png "Visit Sumofleaf Whiteboard")  
[**Output**](challenges/Data-Structures/Trees/LeafSum/SumofleafOutPut.png "Visit Second SumofleafOutPut")  
[**Test**](LeafSumTest/UnitTest1.cs)

#### Largest Value at Each Level 
A method `GetLargestLevelValue()` that finds the largest value at each level of a binary search tree . This requires traversing the tree level by level and recording the maximum value encountered at each level.
[**Whiteboard**](challenges/whiteboard-challenges/LargestValueatEachLevel.png "Visit Sumofleaf Whiteboard")  
[**Output**](challenges/Data-Structures/Trees/LargestLevelValue/LargestValueatEachLevelOutput.png "Visit Second SumofleafOutPut")  
[**Test**](LargestLevelValueTest/UnitTest1.cs)

#### Print Right View 
A method `PrintRightView()` to print the right view of the tree. The class uses a level-order traversal (BFS) to ensure the rightmost node at each level is printed first.
[**Whiteboard**](challenges/whiteboard-challenges/PrintRightView.png "Visit PrintRightView Whiteboard")  
[**Output**](challenges/Data-Structures/Trees/PrintRightView/PrintRightViewOutput.png "Visit PrintRightViewOutPut")  
[**Test**](PrintRightViewTest/UnitTest1.cs)

#### Level with Maximum Number of Nodes
A method `FindMaxLevelNodes()` to find and return the level in a binary tree that has the maximum number of nodes.
[**Whiteboard**](challenges/whiteboard-challenges/LevelwithMaxNodes.png "Visit LevelwithMaxNodes Whiteboard")  
[**Output**](challenges/Data-Structures/Trees/LevelwithMaxNodes/LevelwithMaxNodesOutput.png "Visit LevelwithMaxNodesOutPut")  
[**Test**](LevelwithMaxNodesTest/UnitTest1.cs)

#### Minimum Depth
A method `FindMaxLevelNodes()` to calculating the minimum depth within a specialized class, allowing for better organization and potential future expansions.
[**Whiteboard**](challenges/whiteboard-challenges/MinimumDepth.png "Visit MinimumDepth Whiteboard")  
[**Output**](challenges/Data-Structures/Trees/MinimumDepth/MinimumDepthOutput.png "Visit MinimumDepthOutPut")  
[**Test**](MinimumDepthTest/UnitTest1.cs)