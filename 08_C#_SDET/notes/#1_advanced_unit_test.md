## Test Automation

Test Automation Pyramid

- 70% Unit testing
- 20% Automated Integration, Automated Component and Automated API tests
- 10% Automated GUI Tests
- Manual Session Based Testing

## Unit Testing

Testing individual units of code, given a specific setup and method parameters we get the correct output or a failure which is handled gracefully.

Unit testing is early testing, so errors are less likely to propagate through the program. Validate the code wrt edge cases that are may not have been considered.

* Validate the logic of the code
* Builds a suite of tests to continually verify quality
* Forces you to write code that is easy to test
* Makes it easy to do regression testing
* Time spent in writing tests is repaid in higher quality and time save in maintenance
* Well written tests document code functionality

### When Do You Unit Test ?

AS the code is written, otherwise how do you know it works ? A definition off done may contain a clause requiring that the code is not only written but covered in unit tests and must pass the tests.

### Test Driven Development

Red-green-refactor. For each increment of code: write the smallest possible test case that fulfils the simplest requirement. Run the test (it should fail). Write only the code needed to make the test pass. Con the code be improved ? If so refactor.

## Testing Frameworks

Original testing framework was SUnit (Smalltalk), which was ported to Java (JUnit), C++ (CppUnit), C# and other .NET languages (NUnit), PHP (PHPUnit). Collectively these are referred to as xUnit. Other popular C# frameworks are xUnit.Net and MSTest.

## API

Application Program Interface. Originally defined as the interface exposed by a software library. Now when talking about APIs often what is meant is a third-party API, web sites and web services.

## Web Interface Testing

Selenium. SpecFlow allows you to specify scenarios using Gherkin and map them to program steps (used for BDD - behaviour driven development)

# Advanced Unit Tests

Good tests; FIRST.

Fast, Independent, Repeatable, Self-checking, Timely.

