# Maximum Subarray (Kadane’s algorithm)

**Source file:** `Max_Sub_Array.cs`  
**Class:** `maxSubArray`  
**Method:** `MaxSubArray(int[] nums)`

## What the algorithm does

Find the **largest possible sum** of a contiguous subarray of `nums`. A subarray is a slice `nums[i..j]` with `i ≤ j`.

## How it works (**Kadane’s algorithm**)

Track two values while scanning left to right:

- **`currentSum`** — best sum of a subarray **ending** at the current index.
- **`maxSum`** — best sum seen **anywhere** so far.

At each position `i`:

- Either **extend** the previous subarray: `currentSum + nums[i]`.
- Or **start fresh** at `nums[i]` if that is better than extending.

So: `currentSum = max(nums[i], currentSum + nums[i])`, then `maxSum = max(maxSum, currentSum)`.

This captures “drop a negative prefix” behavior automatically.

## Complexity

- **Time:** O(n).  
- **Space:** O(1) extra (the implementation only uses a few scalars; the method also writes to the console).

## How the code runs (execution flow)

1. Initialize `currentSum` and `maxSum` to `nums[0]`.
2. For `i` from `1` to `nums.Length - 1`, update `currentSum` with `Math.Max(nums[i], currentSum + nums[i])`, then update `maxSum` with `Math.Max(maxSum, currentSum)`.
3. `Console.WriteLine` prints the max (helpful when debugging from `Main`).
4. Return `maxSum`.

## How to try it in this project

Use `new maxSubArray()` and call `MaxSubArray(new[] {-2, 1, -3, 4, -1, 2, 1, -5, 4})` — the maximum contiguous sum is **6** (subarray `[4, -1, 2, 1]`).
