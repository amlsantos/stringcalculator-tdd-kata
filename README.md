![build](https://github.com/amlsantos/stringcalculator-tdd-kata/actions/workflows/build.yml/badge.svg)
![test](https://github.com/amlsantos/stringcalculator-tdd-kata/actions/workflows/test.yml/badge.svg)

# String Calculator TDD Kata

This repository contains a sample solution for the String Calculator TDD Kata, a coding exercise that focuses on Test-Driven Development (TDD) principles. 
The goal of this kata is to implement a simple string calculator with a set of predefined rules.

## Getting Started

### Prerequisites

Ensure you have the following installed on your machine:

- [.NET](https://dotnet.microsoft.com/download)

### Clone the Repository

```bash
git clone https://github.com/amlsantos/stringcalculator-tdd-kata.git
cd stringcalculator-tdd-kata
```

### Build and Run Tests

```bash
dotnet build
dotnet test
```

### String Calculator Kata Requirements

The String Calculator TDD Kata typically involves the following requirements:

1. **Addition of Numbers**: The calculator can add two numbers provided in a delimited string.

2. **Handle Unknown Amount of Numbers**: The calculator should handle an unknown number of arguments.

3. **Custom Delimiters**: Allow the use of custom delimiters for input numbers.

4. **Ignore Numbers Greater than 1000**: Numbers greater than 1000 should be ignored in the sum.

5. **Support Different Delimiter Formats**: The calculator should support different formats for delimiters.

For detailed instructions and examples, refer to the specific requirements of the String Calculator TDD Kata.

### Project Structure
```plaintext
stringcalculator-tdd-kata/
|-- src/
|   |-- Domain/
|       |-- StringCalculator.cs
|   |-- UI/
|       |-- Program.cs
|-- tests/
|   |-- UnitTests/
|       |-- StringCalculatorTests.cs
|-- .gitignore
|-- StringCalculator.sln
|-- README.md
```
# Acknowledgments

We would like to express our gratitude to the following individuals and organizations for their contributions and inspirations:

- [Roy Osherove](http://osherove.com/tdd-kata-1/): The original creator of the String Calculator kata.

- [Steve Smith](https://www.youtube.com/watch?v=H96nnZuQO00): For his TTD implementation, which assisted in creating this repo.

