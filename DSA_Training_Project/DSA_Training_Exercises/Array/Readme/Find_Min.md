# Find Minimum in Array

**Source file:** `Find_Min.cs`  
**Class:** `findMin`  
**Method:** `FindMin(int[] nums)`

## What the algorithm does

Return the **smallest integer** in `nums`.

## How it works

**Linear scan:** assume the first element is the minimum, then compare every other element. If any value is smaller, update the running minimum.

If the array is empty, the code throws `ArgumentException` (no minimum is defined).

## Complexity

- **Time:** O(n) — must inspect every element in the worst case.  
- **Space:** O(1).

## How the code runs (execution flow)

1. If `nums.Length == 0`, throw.
2. Set `min = nums[0]`.
3. Loop all indices `i`; if `nums[i] < min`, set `min = nums[i]`.
4. Return `min`.

## How to try it in this project

Use `new findMin()` and call `FindMin(new[] {3, 1, 4, 1, 5})` — expect **1**.
