# Plus One

**Source file:** `Plus_One.cs`  
**Class:** `plusOne`  
**Method:** `PlusOne(int[] digits)`

## What the algorithm does

Treat `digits` as a **non-negative integer** in **decimal**, most significant digit first (e.g. `[1,2,3]` → 123). Add **one** to that number and return the digits of the result.

## How it works

Add from the **least significant** digit (right end):

1. Walk **right to left** (`i` from `Length-1` down to `0`).
2. If `digits[i] < 9`, increment that digit and **return immediately** (no carry beyond this position).
3. If `digits[i] == 9`, set it to `0` and continue left (carry).
4. If you exit the loop, **every** digit was 9 (e.g. `999` → `1000`): allocate a new array of length `Length + 1`, set `result[0] = 1`, rest stay `0` (default).

## Complexity

- **Time:** O(n) worst case (all 9s).  
- **Space:** O(1) if only a carry in-place; O(n) when allocating the longer array for the all-9s case.

## How the code runs (execution flow)

1. Reverse loop over `digits`.
2. On first digit `< 9`, increment and return `digits`.
3. Otherwise set digit to `0` and continue.
4. After loop, return new array with leading `1`.

## How to try it in this project

`Program.cs` already uses `new plusOne()` with `{9}` — result should be `{1, 0}`. Try `{1,2,3}` → `{1,2,4}`.
