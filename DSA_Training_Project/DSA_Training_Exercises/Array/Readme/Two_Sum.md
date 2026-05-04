# Two Sum

**Source file:** `Two_Sum.cs`  
**Class:** `twoSum`  
**Method:** `TwoSum(int[] nums, int target)`

## What the algorithm does

Given an array of integers and a **target**, return the **indices** of two distinct elements whose values add up to `target`. Assumes exactly one valid pair exists (typical LeetCode setup).

## How it works

Use a **hash map** (`Dictionary<int,int>`) from **value → index** as you scan the array:

1. For each index `i`, compute **complement** = `target - nums[i]` (the number that must pair with `nums[i]`).
2. If the complement is already in the map, you have found the pair: indices `[map[complement], i]`.
3. Otherwise, store `nums[i]` → `i` and continue.

You store **current** number after checking, so the same element is not used twice as two separate picks.

## Complexity

- **Time:** O(n) average for hash lookups and inserts.  
- **Space:** O(n) for the dictionary in the worst case.

## How the code runs (execution flow)

1. Initialize an empty `Dictionary<int,int>`.
2. Loop `i` from `0` to `nums.Length - 1`.
3. Compute `competent` (complement) = `target - nums[i]`.
4. If `map` contains `competent`, return `new int[] { map[competent], i }`.
5. Else set `map[nums[i]] = i`.
6. If no pair is found, return an empty array `new int[] {}`.

## How to try it in this project

In `Program.cs`, use `new twoSum()` and call `TwoSum(new[] {2, 7, 11, 15}, 9)` — expect indices `{0, 1}`.
