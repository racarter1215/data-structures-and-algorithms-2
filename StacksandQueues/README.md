# Code Challenge 10: Stacks and Queues
---

## Stacks and Queues

*Authors: Robert Carter (Amanda Iverson source code)

---

## Summary

Linked Lists are linear data structures which stores elements in a non-contiguous location. One can iterate through them using the Head(first node in list), Current(the node you are at currently within a list), and Next(the command to move from one node to another). 
While we have so far manipulated data returns from one list, on this app we now manipulate the data returns of two Linked Lists by combining their nodes into one list.

## Description

A C# implementation of the combination of two Linked Lists. The purpose of this app is to take two Linked Lists and combine their nodes in an alternating pattern. 
This is accomplished by taking the values of list2 and inserting them into list1 at the appropriate intervals.


---

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Push | Adds node values from one linked list into another at alternating intervals | O(n) | O(1) | zipLists(list1, list2) |



---
### Approach

#### Push()
1. Create new variables for two unique Linked Lists (list1 and list2)
2. If Currentlist1 is equal to null, set list2 head and current to list 1 head and current, then return list1 head
3. Initiate a While loop that will continue to run while the Current node for list1 is not equal to null 
4. If Current node for list2 is not equal to null, set a temporary variable to Currentlist1.Next
5. Set Currentlist1.Next to Currentlist2
6. Set list2 head to Currentlist2.Next
7. Set Currentlist1.Next.Next to the above temporary variable
8. Set Currentlist2 to list2 head
9. Else set Currentlis1 to Currentlist1.Next
10. Increment both CurrentLists by one
11. If Current node for list2 is not equal to null
12. Set Currentlist1.Next to Currentlist2
13. Increment both CurrentLists by one
14.  Return list1

### Efficiency
* Methods that have Big O efficiency O(1) for time
  * zipLists(). Because we are only iterating through two linear Linked Lists, we do not have to navigate over additional lists or nodes.

* Methods that have Big O efficiency O(1) for space
  * zipLists(). Because we are transfering data from one list to another in a way that requires constant coordination between current nodes, space is more complex than O(n), hence the greater rating. 
  
## Solution
No whiteboard was needed for this assignment

---

## Change Log

1.1 Initial submission of app - 20 July 2020

---

