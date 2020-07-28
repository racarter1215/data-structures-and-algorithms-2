# Code Challenge 15: Binary Tree and BST Implementation
---

## Binary Tree and BST Implementation

*Authors: Robert Carter (Amanda Iverson partial source code)
*Collaboration with: Bryant Davis

---

## Summary

Tree traversals are important ways to find and list data. 
I wrote tests for several types of tree traversals to verify they will work given a tree.

## Description

A C# implementation of the PreOrder, InOrder, and PostOrder tree traversal methods. The purpose of this app is to traverse a given tree in a variety of ways.
This is accomplised by creating new trees and utilizing PreOrder (root down), InOrder(bottom left up, then right), and PostOrder(bottom left, then left, right going up to root).


---

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| PreOrder | Starts at root and traverses tree | O(n) | O(1) | PreOrder() |
| InOrder | Starts at bottom left leaf and goes up and down tree | O(n) | O(1) | InOrder() |
  PostOrder | Starts at bottom left leaft and goes left to right all the way up to root | O(n) | O(1) | PostOrder() |


---
### Approach

#### PreOrder()
1. Create a new tree
2. Traverse tree starting from root
3. If left child exists, traverse to leaf
4. If right child exists, traverse to leaf
5. Return traversal

#### InOrder()
1. Create a new tree
2. Traverse tree starting from bottom left leaf
3. If left child exists, traverse to leaf
4. If right child exists, traverse to leaf
5. Return traversal

#### PostOrder()
1. Create a new tree
2. Traverse tree starting from root
3. If left child exists, traverse to leaf
4. If right child exists, even if root not reached, traverse to leaf
5. End traversal at root
5. Return traversal


### Efficiency
* Methods that have Big O efficiency O(n) for time
  * PreOrder(). Because we are only traversing a single tree and nothing more complex, it is efficient for time
  * InOrder(). Because we are only traversing a single tree and nothing more complex, it is efficient for time
  * PostOrder(). Because we are only traversing a single tree and nothing more complex, it is efficient for time

* Methods that have Big O efficiency O(H) for space
  * PreOrder(). Trees can be of varying height, so space is determined by height
  * InOrder(). Trees can be of varying height, so space is determined by height
  * PostOrder(). Trees can be of varying height, so space is determined by height

  
  
## Solution
No whiteboard was needed for this assignment

---

## Change Log

1.1 Initial submission of app - 27 July 2020

---

