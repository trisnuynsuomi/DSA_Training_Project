# Shuffle the Array

**Source file:** `Shuffle_the_Array.cs`  
**Class:** `shuffleTheArray`  
**Method:** `Shuffle(int[] nums, int n)`

## What the algorithm does

The input `nums` has length `2n`: the first `n` elements are **list A**, the next `n` are **list B**. Build a new array of length `2n` that **interleaves** them: `A[0], B[0], A[1], B[1], …, A[n-1], B[n-1]`.

## How it works

For each `i` from `0` to `n-1`:

- Output index `2*i` gets `nums[i]` (from the first half).
- Output index `2*i + 1` gets `nums[i + n]` (from the second half).

No extra logic is needed beyond index arithmetic.

## Complexity

- **Time:** O(n).  
- **Space:** O(n) for the result array.

## How the code runs (execution flow)

1. Allocate `ans` of length `2 * n`.
2. For `i` in `0 .. n-1`, set `ans[2*i]` and `ans[2*i+1]` from `nums`.
3. Return `ans`.

## How to try it in this project

Use `new shuffleTheArray()` and `Shuffle(new[] {2,5,1,3,4,7}, 3)` — expect `{2,3,5,4,1,7}`.
