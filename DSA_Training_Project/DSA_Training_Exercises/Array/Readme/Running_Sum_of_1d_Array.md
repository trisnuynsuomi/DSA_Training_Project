# Running Sum of 1D Array

**Source file:** `Running_Sum_of_1d_Array.cs`  
**Class:** `runningSumOf1DArray`  
**Method:** `RunningSum(int[] nums)`

## What the algorithm does

The **running sum** (prefix sum) at index `i` is the sum of all elements from `nums[0]` through `nums[i]`. The result array has the same length as the input: `result[i] = nums[0] + nums[1] + … + nums[i]`.

## How it works

1. Allocate `result` with the same length as `nums`.
2. Set `result[0] = nums[0]` (no previous elements).
3. For each index `i` from `1` to `n-1`, set  
   `result[i] = nums[i] + result[i - 1]`  
   so each position adds the current element to the **already computed** prefix sum.

This is **incremental**: each step only needs the previous running sum, not a full re-sum.

## Complexity

- **Time:** O(n) — one pass.  
- **Space:** O(n) for the output array (O(1) extra beyond that).

## How the code runs (execution flow)

1. `RunningSum` is called with `nums`.
2. `result[0]` is set from `nums[0]`.
3. The `for` loop updates `result[i]` using `result[i-1]`, which is always defined when `i ≥ 1`.
4. The filled `result` array is returned.

## How to try it in this project

In `Program.cs`, create `new runningSumOf1DArray()`, call `RunningSum` with an array (e.g. `{1,2,3,4}`), and print or inspect the returned array. Expected: `{1,3,6,10}`.
