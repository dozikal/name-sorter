# Name-Sorter [![Build Status](https://travis-ci.com/dozikal/name-sorter.svg?branch=master)](https://travis-ci.com/dozikal/name-sorter)

This is a simple C# console program for sorting a list of names in alphabetic order. The names are sorted by last name first then by any other names that are given.

### Prerequisites

.NET Core should be setup on your machine.

### Running

1) Clone the repository.

2) Navigate to ./src/bin/Release/netcoreapp2.2/win10-x64

```
cd src/bin/Release/netcoreapp2.2/win10-x64
```

3) Run the executable. Replace '<file.txt>' with your file name.

```
name-sorter.exe ./<file.txt>
```

## Tests

Testing is setup using [MSTest](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest) Framework.

```
dotnet test
```

## Built With

* [Visual Studio Code](https://code.visualstudio.com/) - IDE Used
 

## Authors

* **Chiedozie Ihejirika** - [dozikal](https://github.com/dozikal)

