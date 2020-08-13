# Code Challenge Class 28: Quick Sort
---

## Quick Sort

*Authors: Robert Carter (Amanda Iverson gave pseudo code)

---

## Summary

Quick Sorts allow a developer to sort an array through an (admittedly arduous) process that defines a pivot number to compare values against first, then continuing to sort against further pivot values in smaller chunks of array values until all values are sorted.
I wrote this code and whiteboard to best explain to someone with limited or zero knowledge of a quick sort how to conduct one.

## Description

A C# implementation of a quick sort to sort an array by defined pivot values.
This is accomplised by creating a series of if statements that will check values against a defined pivot value and either moving them to the left or right of that value. Once all values are sorted by this method, the array is returned


---

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| QuickSort | Sorts through a given integer array by first comparing all values against the right most value, then repeating this process with smaller chunks of the array. Once completed, the array will be sorted | O(n) | O(1) | QuickSort() |



---
### Approach

#### Sort Through()
1. If left value is < right value, position is the partition with the parameters array, left, and right
2. To sort left, use QuickSort array, left, position -1, and right use QuickSort array, right, position +1.
3. To first sort the array, define pivot is the right most number in the array
4. Define low as left -1.
5. For index is left to right, do the following:
6. If the index value you are currently looking at is <= the pivot value, low++
7. Then Swap(array, index, low)

### Efficiency
* Methods that have Big O efficiency O(n) for time
  * QuickSort(). Though it is one array, it can be of indeterminte length, and given the process this sort takes, it could lead to quite a bit or processing power.
 

* Methods that have Big O efficiency O(1) for space
  * QuickSort(). Because we are only testing a single integer array every time, space will be the same.


  
  
## Solution
![Whiteboard Image](./assets/codechallengeclass28-whiteboard.png)
---

## Change Log

1.1 Initial submission of app - 13 August 2020

---