# Name-Sorter [![Build Status](https://travis-ci.com/dozikal/name-sorter.svg?branch=master)](https://travis-ci.com/dozikal/name-sorter)

This is a simple C# console program for sorting a list of names in alphabetic order. The names are sorted by last name first then by any other names that are given. The program receives a .txt file that contains a list of names and outputs a .txt file of the same names sorted in alphabetic order.

### Prerequisites

.NET Core should be setup on your machine.

## Running

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

## Folder Structure

```
├── .vscode                                      # IDE generated folder
├── src                                          # Source files
│   ├── bin                                      # Compiler generated folder
|   |   ├── Release                              # Test files (alternatively `spec` or `tests`)
|   |   |   └── netcoreapp2.2
|   |   |       ├── win10-x64                    # Test files (alternatively `spec` or `tests`)
|   |   |       |   ├── name-sorter.exe          # Executable file
|   |   |       └── ...                          
|   |   └──...
│   ├── obj                                      # Compiler generated folder
│   ├── FileHandler.cs                           # Source file
│   ├── Sorter.cs                                # Source file
│   ├── Program.cs                               # Source file
│   └── name-sorter.csproj                       # cs project file
├── test                                         # Unit tests folder
│   ├── bin                                      # Compiler generated folder
│   ├── obj                                      # Compiler generated folder
│   ├── FileHandler.Tests.cs                     # Test file
│   ├── Sorter.Tests.cs                          # Test file
│   ├── test-names1.txt                          # Sample file for test
│   ├── test-names2.txt                          # Sample file for test
│   └── tests.csproj                             # cs project file
├── .travis.yml                                  # Travis CI
├── name-sorter.sln                              # Solution file
└── README.md
```


## Built With

* [Visual Studio Code](https://code.visualstudio.com/) - This project was completed using this IDE.
* [Travis CI](https://travis-ci.org/) - Continuous Integration
 

## Authors

* **Chiedozie Ihejirika** - [dozikal](https://github.com/dozikal)

