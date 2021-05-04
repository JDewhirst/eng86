# Unit Tests

## AAA - Arrange, Act, Assert

Arrange - initialise objects and sets the value of the data that is passed to the method under test

Act - Perform the test

Assert - Assert that the expected result and the actual result match

[SetUp] method run before every single test class. Anything we want to be in the state before running tests. 

[TearDown] stuff to do after (every single?) test

[Test] marks a method as a test

[TestCase] allows you to put in parameters [TestCase(10, 2, 4, 80)] &c
But in this case you need to instantiate within the test method.

Example for a calculator

```c#
[TestCase(10,2,4,80)]
[TestCase(0,-3,7,0)]
public void ProductIsCorrect(int a, int b, int c, int expected)
{
    var actual = Program.TripleCalc(a, b, c, out int sum);
    Assert.AreEqual(expected, actual);
}
```

