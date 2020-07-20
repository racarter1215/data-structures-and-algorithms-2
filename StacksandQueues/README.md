# Code Challenge 10: Stacks and Queues
---

## Stacks and Queues

*Authors: Robert Carter (Amanda Iverson source code)

---

## Summary

Stacks and Queues are two forms of data structures that require data input and manipulation in different ways. For stacks, you can add nodes with the Push method, and with queues, you can add a node to the queue with Enqueue.
I wrote tests for several eventualities such as pushing or enqueuing multiple nodes, as well as dequeueing nodes.

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
1. Create a new node
2. node.Next is set to the Top node
3. Top is set to node

#### Enqueue()
1. Create a new node
2. if Front is equal to null, Front and Rear are set to node
3. Else, rear.Next is set to node
4. Rear is set to node.

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

