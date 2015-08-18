[![Build status](https://ci.appveyor.com/api/projects/status/5fp63r349a778veo?svg=true)](https://ci.appveyor.com/project/mwereda/conditions-net)

# Conditions.NET

This is library that provides condition methods, thanks to which code we are writing is more verbose and clean.
Currently it provides conditions for objects, strings, numerics, booleans, datatime and enumerables.

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
  Matches
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
Enumerables:
  ```
  IsEmpty
  HasExactlyOneItem
  HasMoreThanOneItem
  HasAtLeastOneItem
  HasItemsCount
  HasItemsCountAtLeast
  HasMoreItemsThan
  ```
NuGet: https://www.nuget.org/packages/Conditions.NET

# Guards.NET

This library provides guard clauses that could be used to guard against not expected values.
It provides conditions for objects, strings, numerics, datatime and enumerables.

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
Enumerables:
  ```
  Check.If(list).IsEmpty()
  Check.If(list).IsNotEmpty()
  Check.If(list).HasExactlyOneItem()
  Check.If(list).HasMoreThanOneItem()
  Check.If(list).HasAtLeastOneItem()
  Check.If(list).HasItemsCount(3)
  Check.If(list).HasItemsCountAtLeast(5)
  Check.If(list).HasMoreItemsThan(9)
  ```
  
It is possible to configure which exception should be thrown. It can be done by using ```AndThrowThisWhenFail``` static method on Check object. You can configure every check from Guards.NET to throw any exception you want.
Examples of use:
  ```
  Check.AndThrowThisWhenFail<InvalidOperationException>().If(date).IsGreaterThan(referenceDate)
  Check.AndThrowThisWhenFail(()=> new MyCustomException("wrong values", min, max).If(number).IsBetween(5, 10)
  ```
  
NuGet: https://www.nuget.org/packages/Guards.NET

# Contributions

If you would like to contribute I am really happy to include your code to both libraries. Just create pull request with your code. Please stick to standards of code used in solution.