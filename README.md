# _Numbers to Words_

#### _Epicodus Project May 14, 2020_

#### By _**Matt Stroud**_

## Description

_An Epicodus individual project using C# and MSTest. This project prioritizes unit testing to validate code and logic before writing code._
_The application will take a number from the user and convert it to words._
_Example: 5139 will be returned as "five thousand one hundred thirty nine"_

## Specs
| Behavior                                                 | Input             | Output           |
|:---------------------------------------------------------|:------------------|-----------------:|
| The program will accept a number from user.              | 123               | N/A              |
| The program will validate the input is a number.         | 123               | true             |
| The program will store the numbers digits in a queue.    | 123               | 1, 2, 3          |
| The program will dequeue, and check the queue size.      | 123               | 2, 3   ( 2)      |
| The program will retrieve digit name from list           | 123               | 1 = "hundred     |
| The program will repeat for every digit in the queue.    | 123               | one hundred twenty three |

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
  (VSCode, Atom, etc.)
3. To install the REPL dotnet script, run dotnet tool install -g dotnet-script in your terminal.
4. Run the program with the command dotnet build.

## Known Bugs

There are no known bugs at the time of this update.
 
## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/mlstroud/scrabble/issues) here on GitHub._

## Technologies Used

* C#
* .NET Core
* MSTest
* Git

### License

This software is licensed under the MIT license.

Copyright © 2020 **_Matt Stroud_**