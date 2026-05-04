# Find Maximum in Array

**Source file:** `Find_Max.cs`  
**Class:** `findMax`  
**Method:** `FindMax(int[] nums)`

## What the algorithm does

Return the **largest integer** in `nums`.

## How it works

**Linear scan:** treat `nums[0]` as the current maximum, then for each next element, if it is larger, update `max`. Same pattern as find-min, with the comparison reversed.

## Complexity

- **Time:** O(n).  
- **Space:** O(1).

## How the code runs (execution flow)

1. Set `max = nums[0]`.
2. For each `i`, if `nums[i] > max`, set `max = nums[i]`.
3. Return `max`.

*(Note: if `nums` could be empty, you would guard similarly to `FindMin`.)*

## How to try it in this project

Use `new findMax()` and call `FindMax(new[] {3, 1, 4, 1, 5})` — expect **5**.
