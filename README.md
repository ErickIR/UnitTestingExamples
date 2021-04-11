## The Three Rules of TDD

1. You are not allowed to write any production code unless it is to make a failing unit test pass.
2. You are not allowed to write any more of a unit test than is sufficient to fail; and compilation failures are failures.
3. You are not allowed to write any more production code than is sufficient to pass the one failing unit test.

Which means the workflow is:

1. Write a failing test. Stop writing the test as soon as it fails.
2. Write the minimal production code required for the test to pass. Stop writing any code once the test passes.
3. Refactor the test code and the production code without altering the functionality. All tests should pass.

## Usage
To run the tests, run `npm run test`.

For a true TDD experience: use [wallaby.js](https://wallabyjs.com/) with the included `wallaby.js` file.

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

## String Calculator
Made popular by [Roy Osherove](http://osherove.com/tdd-kata-1/).

#### Before you start:
* **Try not to read ahead.**
* **Do one task at a time. The trick is to learn to work incrementally.**
* **Make sure you only test for correct inputs. there is no need to test for invalid inputs for this kata**

This kata is one of the simplest and best ways to practice step-by-step fluent tdd, and provides an easy way to get proficient in a language.

Write a method `add` under an object `StringCalculator` that, given a delimited string, returns the sum of the numbers in the string.

1. An empty string returns zero `'' => 0`
2. A single number returns the value `'1' => 1` `'2' => 2`
3. Two numbers, comma delimited, returns the sum `'1,2' => 3` `'10,20' => 30`
4. Two numbers, newline delimited, returns the sum `'1\n2' => 3`
5. Three numbers, delimited either way, returns the sum `'1\n2,3\n4' => 10`
6. Negative numbers throw an exception with the message `'-1,2,-3' => 'negatives not allowed: -1,-3'`

**stop here if you are a beginner. Continue if you can finish the steps so far in less than 30 minutes.**

7. Numbers greater than 1000 are ignored
8. A single char delimiter can be defined on the first line starting with `//` (e.g `//#\n1#2` for a ‘#’ as the delimiter)
9. A multi char delimiter can be defined on the first line starting with `//` (e.g. `//###\n1###2` for ‘###’ as the delimiter)
