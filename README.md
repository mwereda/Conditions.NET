# Conditions.NET

This is library that provides condition methods, thanks to which code we are writing is more verbose and clean.
Currently it provides conditions for objects, strings, numerics, booleans and datatime.

Available conditions:
Object:
  ```
  IsNull
  IsNotNull
  ```
String:
  ```
  IsNullOrEmpty
  IsNotNullOrEmpty
  IsGuid
  IsEmailAddress
  HasLength
  HasLengthAtLeast
  ```
Numerics:
  ```
  IsGreaterThan
  IsGreaterOrEqual
  IsLowerThan
  IsLowerOrEqual
  IsBetween
  ```
DateTime:
  ```
  IsGreaterThan
  ```
Boolean:
  ```
  IsTrue
  IsFalse
  ```

NuGet: https://www.nuget.org/packages/Conditions.NET

# Conditions.Guards.NET

This library provides guard clauses that could be used to guard against not expected values.
It provides conditions for objects, strings, numerics and datatime.

NuGet:

# Contributions

If you would like to contribute I am really happy to include your code to both libraries. Just create pull request with your code. Please stick to standards of code used in solution.