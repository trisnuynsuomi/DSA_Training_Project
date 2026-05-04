# Max Profit (stock variant)

**Source file:** `Max_Profit.cs`  
**Class:** `maxProfit`  
**Method:** `MaxProfit(int[] prices)`

## What the algorithm does

Same family as **Best Time to Buy and Sell Stock**: one buy and one sell, chronological days, maximize `sell − buy`. The implementation tracks the **minimum price so far** and the **best profit** when selling on a later day.

## How it works

- Scan `prices` with index `i` from `0` to `prices.Length - 2` (the loop condition in this file is `i < prices.Length - 1`).
- Maintain **`min`** = smallest price seen in the scanned prefix.
- If `prices[i]` is not a new minimum, treat it as a possible **sell** day: `profit = prices[i] - min`, update **`maxProfit`** if this profit is larger.

## Complexity

- **Time:** O(n) with respect to the loop length (visits all but the last index in the current code).  
- **Space:** O(1).

## How the code runs (execution flow)

1. `min = int.MaxValue`, `maxProfit = 0`.
2. Loop while `i < prices.Length - 1` (so the last element is not visited in the loop).
3. Update `min` or `maxProfit` as described.
4. Return `maxProfit`.

## Note on the implementation

The loop stops before the **last** price. If the best sell day were the last day, that case is not considered inside the loop. If you need the true maximum profit for all valid buy/sell pairs, the loop should include the last index (compare with `bestTimeToBuyAndSellStock`, which iterates the full array).

## How to try it in this project

Use `new maxProfit()` with the same style of tests as the other stock problem and compare results with `bestTimeToBuyAndSellStock` on edge cases (e.g. strictly increasing prices).
