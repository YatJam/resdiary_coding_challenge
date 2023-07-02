# ResDiary Coding Challenge Submission

## Requirements
You should implement a function or class that can be called on to
provide the following behaviour:

Given an array of length >= 0, and a positive integer N, return the contents of the array divided into N equally sized arrays.
Where the size of the original array cannot be divided equally by N, the final part should have a length equal to the remainder.

### Example pseudo-code:

```
groupArrayElements([1, 2, 3, 4, 5], 3);
// [ [ 1, 2 ], [ 3, 4 ], [ 5 ] ]
```

## Solution
This repository consists of three parts:
1. a library implementing a `GroupArrayElements` method which meets the spec above:

    - returns an array with contents of the `inputArray` divided into a number of parts specified by the `numOfParts` argument,
    - if the `inputArray` cannot be divided equally, the final part contains the remainder,
    - if `numOfParts` is more than the length of the `inputArray`, the result will contain empty arrays. Note: depending on the real-life requirements, this case could be handled to throw
    an exception instead.
1. a Demo console application which takes user input, calls the `GroupArrayElements` on it, and presents the result back to the user
1. unit tests written using xUnit

## How to run

### Prerequsites
Please ensure you have the [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) installed on your machine.

### Executing the code

1. Clone the repo: from your terminal, run `git clone ...`
1. Go to the project directory: `cd resdiary_coding_challenge`
1. To run the Demo app, run `dotnet run --project Demo/Demo.csproj`
1. To execute the test, run `dotnet test GroupArrayLibraryTest/GroupArrayLibraryTest.csproj`

### Using the library
To use the `GroupArrayLibrary`, you need to reference it in your project, e.g.:

```
dotnet add Demo/Demo.csproj reference GroupArrayLibrary/GroupArrayLibrary.csproj
```

You can then access its method in your program:

```
using GroupArrayLibrary;

class Program
{
    static void Main(string[] args)
    {
        ...
        object[][] result = GroupArray.GroupArrayElements(inputArray, numOfParts);
        ...
    }
}
```
