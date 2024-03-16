# Code:You Spring 2024 Software Development 
## Demos & Solutions | Tuesdays 

**In Program.cs, comment out all method calls other than what you want to run.**

### Solution: "A bat and a baseball cost $110..." 
*If you have access to the class Slack channel, find the problem posted 3/13/2024 at https://codelouisville.slack.com/archives/C06P2DP754G/p1710361822875309*

### Solution: Longest Collatz Sequence 
*The problem posted 3/13/2024 by Sandy at https://projecteuler.net/problem=14*

### Demo: A Simple Car Race 

This is a simple console app that borrows traits from real-world car races. Even if you don't understand the code, the characteristics of cars and races should be familiar enough to allow you to ask good questions about it.

**Note:** There's a bug that causes the declared winner to be wrong sometimes. Can you figure out why?

Concepts demonstrated:
- Custom classes with Object-oriented programming (OOP)
- Static classes `RacingLineup.cs`
- Instance methods `race.RunLap()` in Program.cs and `currentCar.MoveForward(distanceToMove)` in Race.cs
- Static methods `RacingLineup.BuildLineup()` in Race.cs
- Loops `foreach, while`
- Conditions `if`
- Collections `array[], List<>`
- Flag boolean variable `Race.IsOngoing`
- Accessors `{ get; private set; }`
- Default class parameter values `CurrentLap { get; private set; } = 0;`
- Constructor arguments `public Race(int length)` and methods `Lineup = RacingLineup.BuildLineup()` in Race.cs
- String interpolation `Console.WriteLine($"The winner is the {Winner.Number} car!")`
- Using .NET classes `var randomIntGenerator = new Random()` in Program.cs
