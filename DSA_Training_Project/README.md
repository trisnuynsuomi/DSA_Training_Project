# DSA Training Project

Personal **data structures and algorithms (DSA)** practice in **C#**, organized as a small **.NET 8** console application. Each exercise is a self-contained class under the Array topic folder; you wire whichever solution you want to try into `Program.cs` and run it locally.

## Purpose

- Implement classic array problems (LeetCode-style) in C#.
- Keep short **markdown explanations** next to the code: how the algorithm works, complexity, and how execution flows.
- Track **how many Array topics you have studied** versus how many remain (see progress doc below).

## Tech stack

| Item | Version / notes |
|------|-----------------|
| Language | C# |
| SDK | .NET **8.0** (`TargetFramework`: `net8.0`) |
| Project type | Executable console (`OutputType`: `Exe`) |
| Nullable reference types | Enabled |

## Repository layout

```
DSA_Training_Project/
├── README.md                    ← this file — project overview
├── Program.cs                   ← entry point; change which class/method you exercise
├── DSA_Training_Project.csproj  ← SDK-style project file
└── DSA_Training_Exercises/
    ├── PROGRESS.md              ← Array checklist + progress (e.g. 1/12)
    └── Array/
        ├── *.cs                 ← solution classes (one file per problem)
        └── Readme/
            ├── README.md        ← index of all Array explanation files
            └── *.md             ← one guide per exercise (matches `*.cs` name)
```

- **Namespace** for array solutions: `DSA_Training_Project.DSA_Training_Exercises.Array`.
- **Class names** are lower camelCase in this repo (e.g. `plusOne`, `twoSum`); file names use underscores for readability on disk.

## How to run

From this project directory (where the `.csproj` lives):

```bash
dotnet run
```

`Main` in `Program.cs` currently instantiates a solution and calls a method (example: `plusOne` with digit array `{9}`). Replace that with whichever exercise you are practicing—construct the solution type and pass sample inputs, optionally printing results.

Build without running:

```bash
dotnet build
```

## Documentation

| Document | Role |
|----------|------|
| [DSA_Training_Exercises/PROGRESS.md](DSA_Training_Exercises/PROGRESS.md) | Array topic **total** (12), **checklist**, optional shell command to count completed rows, **progress bar** template |
| [DSA_Training_Exercises/Array/Readme/README.md](DSA_Training_Exercises/Array/Readme/README.md) | Index linking each Array exercise to its `.md` explanation |

Each explanation file under `Array/Readme/` corresponds to a `.cs` file in `Array/` with the same base name (e.g. `Two_Sum.cs` → `Two_Sum.md`).

## Scope today

The checked-in exercises all live under **Array** (prefix sums, hash maps, Kadane, two pointers, etc.). Other DSA areas (linked lists, trees, graphs) are not in this tree yet; the project can grow by adding new folders under `DSA_Training_Exercises/` following the same pattern.
