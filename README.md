# Pattern Training

This is a repository containing the projects following the exercises given and described in the Head First Design Patterns book adapted for C#.

## PatternIntro

Follows the Duck tutorial from the Intro to Patterns chapter. 

The **Strategy Pattern** defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

Key takeaways:
- The part of the code that is prone to changes should be isolated from the static part and encapsulated into separate entities (in the given case into sets of behaviors)
- Setters allow to change the instance props at the runtime (using properties vs fields)
- Composition over inheritance: inject properties that can change dynamically into classes rather than use fixed inheritance (HAS-A is better than IS-A)

## StrategyPatternTask

Project for the task given in the end of the Intro to Patterns chapter.

