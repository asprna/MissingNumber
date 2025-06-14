# 🔍 Missing Number Finder (C# Console App using SOLID Principles)

This project is a simple C# console application that finds the **missing number** in a sequence of distinct integers from the range `0` to `n`. It demonstrates **SOLID design principles**, test-driven development, and clean code practices.

---

## ✅ Problem Statement

Given an array of `n` distinct integers where each number is in the range `0` to `n`, **find the one number that is missing**.

### Examples

- Input: `[3, 0, 1]` → Output: `2`
- Input: `[9, 6, 4, 2, 3, 5, 7, 0, 1]` → Output: `8`

---

## 🧠 Calculation Logic

We use the **Sum Formula approach**, which is based on the mathematical formula for the sum of the first `n` natural numbers:

\[
\text{Expected Sum} = \frac{n(n + 1)}{2}
\]

- Let `n` be the **length** of the input array.
- Calculate the **actual sum** of the array.
- Subtract the actual sum from the expected sum:

\[
\text{Missing Number} = \text{Expected Sum} - \text{Actual Sum}
\]

---

## 🔒 Validations Included

The solution includes validation to ensure input integrity:

1. ✅ **Null input check** – Throws `ArgumentNullException`
2. 🚫 **Duplicate check** – Throws `ArgumentException`
3. 🚫 **Out-of-range numbers** – Throws `ArgumentOutOfRangeException`

---

## 🚀 How to Run

### Prerequisites
- [.NET SDK 9]

### Run the Console App

```bash
dotnet run --project MissingNumberApp
```

### Run Unit Tests

```bash
dotnet test
```

> The solution uses `MSTest` as the test framework and includes tests for valid inputs, null inputs, duplicates, and out-of-range numbers.

---

## 📁 Project Structure

```
MissingNumber/
├── MissingNumber/
|   ├──App/
|   ├── MissingNumberApp.cs                 # Console runner using injected finder
|   ├──Interfaces/
|   ├── IMissingNumberFinder.cs             # Interface for strategy
|   ├──Services/
|   ├── SumFormularMissingNumberFinder.cs   # Implementation using sum formula
├── Program.cs
├── MissingNumber.UnitTest/
|   ├──Services/
|   ├── SumFormularMissingNumberFindTest.cs
|   ├── MissingNumberFindSpecification.cs   # Test base class
```

---

## 👨‍💻 Author

Created by **Ash** – demonstrating clean code, testability, and architecture using real-world patterns in C#.