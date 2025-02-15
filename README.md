# C# Implicit Conversion Operator Bug: Unexpected Behavior with Arithmetic

This repository demonstrates a subtle bug related to implicit conversion operators in C#.  The bug arises when combining implicit conversions with arithmetic operations.  The implicit conversion operator allows seamless conversion between a custom class and an integer type. However, when performing arithmetic with the custom class and then implicitly converting the result, the behavior might not be intuitive.

## Bug Description
The provided code showcases unexpected behavior when adding an integer to a custom class object that has an implicit conversion operator to an integer and vice-versa. The implicit conversion works well for simple assignments, but the arithmetic operation can yield unexpected results.

## How to Reproduce
Clone this repository and run the `bug.cs` file.  Observe the output, noting that `obj3`'s value is not what one might naively expect.

## Solution
The `bugSolution.cs` file provides a corrected version, explaining how the bug was resolved.

## Note
This bug highlights the need to carefully consider the implications of implicit conversion operators, especially when they are used with arithmetic or other operations. Always thoroughly test such operators to prevent unexpected behavior in your applications.