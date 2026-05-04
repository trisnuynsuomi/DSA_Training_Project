# Best Time to Buy and Sell Stock

**Source file:** `Best_Time_to_Buy_and_Sell_Stock.cs`  
**Class:** `bestTimeToBuyAndSellStock`  
**Method:** `MaxProfit(int[] prices)`

## What the algorithm does

You are given **daily stock prices** in order. You may buy once and sell once; buy must happen **before** sell. Return the **maximum profit** (sell price − buy price), or `0` if no profit is possible.

## How it works

One left-to-right pass:

- Keep **`min`** = lowest price seen **so far** (best buy day up to the current index).
- For each day `i`, if `prices[i]` is lower than `min`, update `min` (better buy).
- Otherwise, treat today as a **sell** day: profit = `prices[i] - min`; track the maximum profit in **`max`**.

You never look backward from a future sell to an invalid earlier buy: `min` always refers to a day at or before `i`.

## Complexity

- **Time:** O(n).  
- **Space:** O(1).

## How the code runs (execution flow)

1. `min = int.MaxValue`, `max = 0`.
2. For each `prices[i]`, if it is a new minimum, set `min = prices[i]`.
3. Else compute `profit = prices[i] - min` and possibly update `max`.
4. Return `max`.

## How to try it in this project

Use `new bestTimeToBuyAndSellStock()` and call `MaxProfit(new[] {7, 1, 5, 3, 6, 4})` — expect **5** (buy at 1, sell at 6).
