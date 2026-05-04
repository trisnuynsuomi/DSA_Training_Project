# Max Consecutive Ones

**Source file:** `Max_Consecutive_Ones.cs`  
**Class:** `maxConsecutiveOnes`  
**Method:** `MaxConsecutiveOnes(int[] nums)`

## What the algorithm does

`nums` contains only `0` and `1`. Return the length of the **longest contiguous block of 1s**.

## How it works

**Single pass** with a running streak:

- **`current`** — length of the block of 1s ending at the current index (reset to `0` when you see `0`).
- **`max`** — best streak seen.

When `nums[i] == 1`, increment `current` and update `max` with `Math.Max(max, current)`. When `nums[i] == 0`, set `current = 0` (the streak breaks).

## Complexity

- **Time:** O(n).  
- **Space:** O(1).

## How the code runs (execution flow)

1. `current = 0`, `max = 0`.
2. For each element, branch on `1` vs not `1` as above.
3. Return `max`.

## How to try it in this project

Use `new maxConsecutiveOnes()` and `MaxConsecutiveOnes(new[] {1,1,0,1,1,1})` — expect **3** (last three ones).
