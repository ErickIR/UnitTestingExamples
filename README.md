## What's TDD?
Test-driven development (TDD) is a software development process relying on software requirements being converted to test cases before software is fully developed, and tracking all software development by repeatedly testing the software against all test cases. This is opposed to software being developed first and test cases created later. 

## How to TDD? and what's Red-Green-Refactor?
1. Add a test
2. Run all tests. The new test should fail because it should not be implemented yet.
3. Write the simples code that passes the new test.
4. All tests should now pass.
5. Refactor as needed, using tests after each refactor to ensure that functionality is preserved.
* **SOLID**
* **DRY**
* **KISS**
* **YAGNI**

## Test Structure
* Arrange: Set up all conditions needed for testing (create any required objects, allocate any needed resources, and so on).
* Act: Invoke the method to be tested with possible parameters or values.
* Assert: Verify that the tested method returns the output as expected.
* Cleanup: Return the system to an initial state.

## The Three Rules of TDD

1. You are not allowed to write any production code unless it is to make a failing unit test pass.
2. You are not allowed to write any more of a unit test than is sufficient to fail; and compilation failures are failures.
3. You are not allowed to write any more production code than is sufficient to pass the one failing unit test.
4. **TEST OFTEN**

Which means the workflow is:

1. Write a failing test. Stop writing the test as soon as it fails.
2. Write the minimal production code required for the test to pass. Stop writing any code once the test passes.
3. Refactor the test code and the production code without altering the functionality. All tests should pass.

## What to Unit Test?

### **Boundary Conditions**
Boundary conditions are very critical to the success of any software code ever written. All your business validation/rules are actually a candidate for Boundary Unit Tests.

Identifying boundary conditions is very important for unit testing, such as:
1. Empty or missing values (such as 0, "", or null).
2. Inappropriate values that are not realistic from a business point of view, such as a person's age of -1 or 200 years or so.
* Date of Birth is tomorrow's date or time in the future.
* Duplicates in lists that shouldn't have duplicates.
* The password is the same as either First name or Last name
* Special characters or case related conditions.
* Formatting of data, for example, the name must be capitalized. For example Vidya Vrat, Agarwal.
* Type of acceptable values in a field. For example, the name can't hold a numeric, and age can't hold letters.
3. Range is another critical thing to test and it's often coded as business validation rules.

### **Error Conditions**
Building a real-world application causes real-world errors at run-time and errors do happen. Hence, you should be able to test that your code handles all such errors, for example, think of the following scenarios:

1. Can't handle DivideByZeroException
2. Consider the scenario of AccessDenied
3. Don't ignore NullReferenceExceptions
4. Check for existence; FileNotFoundException, DirectoryNotFoundException and all sort of EntityNotFoundExceptions.

# Katas

## Greeter

#### Before you start:
* **Try not to read ahead.**
* **Do one task at a time. The trick is to learn to work incrementally.**

This kata demonstrates the problems of static scoped functions and objects.

All tests should always pass, regardless of environment conditions.

1. Write a `Greeter` class with `greet` function that receives a `name` as input and outputs `Hello <name>`. The signature of `greet` should not change throughout the kata. You are allowed to construct `Greeter` object as you please.
2. `greet` trims the input
3. `greet` capitalizes the first letter of the name
4. `greet` returns `Good morning <name>` when the time is 06:00-12:00
5. `greet` returns `Good evening <name>` when the time is 18:00-22:00
6. `greet` returns `Good night <name>` when the time is 22:00-06:00
7. `greet` logs into console each time it is called

## Game of Life

https://kata-log.rocks/game-of-life-kata

## Advantages and Disadvantages

https://www.geeksforgeeks.org/advantages-and-disadvantages-of-test-driven-development-tdd/

## Classicist vs Mockist

https://agilewarrior.wordpress.com/2015/04/18/classical-vs-mockist-testing/

## Resources
* https://github.com/wix/tdd-katas
* https://en.wikipedia.org/wiki/Test-driven_development
* https://www.tutorialspoint.com/software_testing_dictionary/unit_testing.htm
* https://www.guru99.com/unit-testing-guide.html

