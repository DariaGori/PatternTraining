# Pattern Training

This is a repository containing the projects following the exercises given and described in the Head First Design Patterns book adapted for C#.

## PatternIntro

Follows the Duck tutorial from the Intro to Patterns chapter. 

The **Strategy Pattern** defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

### Key takeaways
- The part of the code that is prone to changes should be isolated from the static part and encapsulated into separate entities (in the given case into sets of behaviors)
- Setters allow to change the instance props at the runtime (using properties vs fields)
- Composition over inheritance: inject properties that can change dynamically into classes rather than use fixed inheritance (HAS-A is better than IS-A)

## StrategyPatternTask

Project for the task given in the end of the Intro to Patterns chapter.

## ObserverPattern

Follows the Weather Station tutorial from the Observer Pattern chapter.

The **Observer Pattern** defines a one-to-many dependency between objects so that when one object changes state, all of its dependents are notified and updated automatically.

### Key terms and takeaways
- The Observer Pattern provides an object design where subjects and observers are loosely coupled. When two objects are loosely coupled, they can interact, but have very little knowledge of each other
- Strive for loosely coupled designs between objects that interact

## ObserverPatternInbuiltTools

This project provides an implementation of the Weather Station example described in the **ObserverPattern** project utilizing the built-in capabilities of .NET.

Reference materials for the Observer pattern inbuilt capabilities can be found here: https://docs.microsoft.com/en-us/dotnet/standard/events/observer-design-pattern.

## DecoratorPattern

Follows the Starbuzz tutorial from the Decorator Pattern chapter.

The **Decorator Pattern** attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.

### Key terms and takeaways
- Decorators have the same supertype as the objects they decorate
- The decorator adds its own behavior either before and/or after delegating to the object it decorates to do the rest of the job
- Objects can be decorated at a runtime