# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it has been assigned a value.  The code attempts to read the value of `MyProperty` within the `MyMethod` function, but `MyProperty` is never initialized before this access. This will cause a `NullReferenceException` at runtime if the property is of a reference type, or a different exception type depending on the property type if it is a value type, such as an `System.InvalidOperationException` for structs.

## How to Reproduce

1. Compile and run the code in `bug.cs`.
2. Observe the `NullReferenceException` or `System.InvalidOperationException`.

## Solution

The solution is to ensure `MyProperty` is assigned a value before it is accessed. See `bugSolution.cs` for a corrected version of the code.