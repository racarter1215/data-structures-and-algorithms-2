# Code Challenge Class 32: Tree Intersection
---

## Tree Intersection

*Authors: Robert Carter 

---

## Summary

The Tree Intersection method allows a developer to traverse two binary trees and return values that appear on both trees. This is useful to check to sets of values for repetition. 
I wrote this code and whiteboard to best explain to someone with limited or zero knowledge of binary trees and how to traverse them conduct a traversal.

## Description

A C# implementation of an repeated word method to find repeating values between two binary trees.
This is accomplised by creating a two binary trees, putting all values of the first in an array, then checking the values of the second against those in the array. One would then push all repetitive values in a finalArray, then return the finalArray once all values have been checked.


---

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| CheckTheTrees | Creates two binary trees, enters all values of first tree into array, checks all values of second tree against array, adds all multiple values into finalArray, returns finalArray | O(n) | O(1) | CheckTheTrees() |



---
### Approach

#### ReadThrough()
1. Create new binary tree
2. Create second binary tree
3. Traverse first tree from top down, left right.
4. Add all values to array1
5. Once completed, traverse second tree top down, left right.
6. Compare each value in second tree to all values in array1 via for loop
7. Push all matching values into finalArray
8. Once second tree traversed, return finalArray

### Efficiency
* Methods that have Big O efficiency O(logn) for time
  * CheckTheTrees(). Because we are only testing a single string array, it will not generate extra time requirements.
 

* Methods that have Big O efficiency O(1) for space
  * CheckTheTrees(). Though we are iterating through a whole array of any given size, the size doesn't change.


  
  
## Solution
![Whiteboard Image](./assets/codechallengeclass32-whiteboard.png)
---

## Change Log

1.1 Initial submission of app - 19 August 2020

---