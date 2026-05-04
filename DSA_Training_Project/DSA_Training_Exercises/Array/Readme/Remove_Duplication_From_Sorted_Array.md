# Remove Duplicates from Sorted Array

**Source file:** `Remove_Duplication_From_Sorted_Array.cs`  
**Class:** `removeDuplicateFromSortedArray`  
**Method:** `RemoveDuplicates(int[] nums)`

## What the algorithm does

`nums` is **sorted in non-decreasing order**. **Remove duplicates in place** so each value appears once, keeping **relative order**. Return **`k`**, the new logical length (first `k` positions are the unique values).

## How it works (**two pointers**)

- **`slow`** — index of the last written unique value (or the right edge of the deduplicated prefix).
- **`fast`** — scans ahead for the **next** value different from `nums[slow]`.

When `nums[fast] != nums[slow]`, advance `slow`, then copy `nums[fast]` to `nums[slow]`. Duplicates are skipped by moving `fast` without moving `slow`.

If the array is empty, return `0`.

## Complexity

- **Time:** O(n) — `fast` visits each element once.  
- **Space:** O(1) extra (mutates `nums`).

## How the code runs (execution flow)

1. Empty check → return `0`.
2. `slow = 0`; loop `fast` from `1` to end.
3. On inequality, increment `slow` and assign `nums[slow] = nums[fast]`.
4. Return `slow + 1` (count of unique elements).

## How to try it in this project

Use `new removeDuplicateFromSortedArray()`, pass `new[] {0,0,1,1,1,2,2,3}`, call `RemoveDuplicates` — returns **4**; the first four slots should be `0,1,2,3`.
