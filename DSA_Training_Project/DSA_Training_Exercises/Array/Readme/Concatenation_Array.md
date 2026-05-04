# Array Concatenation

**Source file:** `Concatenation_Array.cs`  
**Class:** `concatenationArray`  
**Method:** `GetConcatenation(int[] nums)`

## What the algorithm does

Build an array of length **twice** `nums.Length`: first half is a **copy of `nums`**, second half is **another copy** of `nums`. Equivalently: `nums` concatenated with itself.

## How it works

Let `n = nums.Length`. Allocate length `2n`. For each `i` in `0 .. n-1`:

- `ans[i] = nums[i]` (first copy).
- `ans[i + n] = nums[i]` (second copy).

## Complexity

- **Time:** O(n).  
- **Space:** O(n) for the output.

## How the code runs (execution flow)

1. `n = nums.Length`.
2. Create `ans` of size `2 * n`.
3. Single loop: fill front and back segments from `nums`.
4. Return `ans`.

## How to try it in this project

Use `new concatenationArray()` and `GetConcatenation(new[] {1,2,1})` — expect `{1,2,1,1,2,1}`.
