# Code Challenge Class 31: Repeated Word
---

## Repeated Word

*Authors: Robert Carter 

---

## Summary

The Repeated word method allows a developer to search a sentence or paragraph for the most used word (string) found within. This is useful to ensure that a word isn't being overrused or used out of context. 
I wrote this code and whiteboard to best explain to someone with limited or zero knowledge of an repeated word method how to conduct one.

## Description

A C# implementation of an repeated word method to suss out the most used word (string) in a pagragraph.
This is accomplised by creating a linked list out of the strings and utilize a while loop and counter to count the amount of times each string is used. At the end of the list, sort the amounts, and return the largest amount.


---

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| ReadThrough | Sorts through a given string array to find and return the most used string | O(n) | O(1) | ReadThrough() |



---
### Approach

#### ReadThrough()
1. Create a new linked list using the strings as values
2. Set current node to head
3. Iterate through list
4. When a value is seen, push the amount of times you've seen it into a finalCount array
5. Once you break while loop (null is found), sort array least value to greatest
6. Return greatest value

### Efficiency
* Methods that have Big O efficiency O(n) for time
  * ReadThrough(). Because we are only testing a single string array, it will not generate extra time requirements.
 

* Methods that have Big O efficiency O(1) for space
  * ReadThrough(). Though we are iterating through a whole array of any given size, the size doesn't change.


  
  
## Solution
![Whiteboard Image](../assets/codechallengeclass31-whiteboard.png)
---

## Change Log

1.1 Initial submission of app - 11 August 2020

---
