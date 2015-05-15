# Conditions.NET

This is library that provides condition methods, thanks to which code we are writing is more verbose and clean.
Currently it provides conditions for objects, strings, numerics, booleans and datatime.

**Available conditions:**

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

**Available checks:**

Object:
  ```
  Check.If(@object).IsNotNull()
  Check.If(@object).IsNull()
  ```
String:
  ```
  Check.If(@string).IsNotNullOrEmpty()
  Check.If(@string).IsGuid()
  Check.If(@string).IsEmailAddress()
  Check.If(@string).HasLength(5)
  Check.If(@string).HasLengthAtLeast(5)
  ```
Numeric:
  ```
  Check.If(number).IsGreaterThan(5)
  Check.If(number).IsGreaterOrEqual(5)
  Check.If(number).IsLowerThan(5)
  Check.If(number).IsLowerOrEqual(5)
  Check.If(number).IsBetween(5, 10)
  ```
DateTime:
  ```
  Check.If(date).IsGreaterThan(referenceDate)
  ```
  
NuGet:

# Contributions

If you would like to contribute I am really happy to include your code to both libraries. Just create pull request with your code. Please stick to standards of code used in solution.