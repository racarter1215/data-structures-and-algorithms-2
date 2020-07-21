# Code Challenge 10: Stacks and Queues
---

## Stacks and Queues

*Authors: Robert Carter (Amanda Iverson source code)

---

## Summary

Stacks and Queues are two forms of data structures that require data input and manipulation in different ways. For stacks, you can add nodes with the Push method, and with queues, you can add a node to the queue with Enqueue.
I wrote tests for several eventualities such as pushing or enqueuing multiple nodes, as well as dequeueing nodes.

## Description

A C# implementation of the Push of nodes into a Stack and the Enqueueing of nodes into a Queue. The purpose of this app is to take a newly created node and Push it into a Stack (testing for a variety of ways to do this) and Enqueue a node into a Queue (testing for a variety of ways to do this)
This is accomplised by creating new nodes and setting them to either the Top of a Stack or the Rear of a Queue.


---

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Push | Adds a node to the Top of a Stack | O(1) | O(1) | Push() |
| Enqueue | Adds a node to the Rear of a Queue | O(1) | O(1) | Push() |


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
* Methods that have Big O efficiency O(n) for time
  * Push(). Because we are only testing a single stack and nothing more complex, it is efficient for time
  * Queue(). Because we are only testing a single queue and nothing more complex, it is efficient for time

* Methods that have Big O efficiency O(1) for space
  * Push(). Because we are only adding one or a few nodes to an existing stack, it doens't require much space
  * Queue(). Because we are enqueuing one or a few nodes to an existing queue, it doesn't require much space

  
  
## Solution
No whiteboard was needed for this assignment

---

## Change Log

1.1 Initial submission of app - 20 July 2020

---

