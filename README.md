# Design Patterns

Design patterns refer to reusable solutions to common problems that occur during software design and development. These patterns have been identified and documented by experts in the field of software development and are intended to help developers create robust and maintainable software systems.

Design patterns are typically used to solve common problems that occur during the development process, such as object creation, object relationships, algorithm design, and communication between objects. By using these patterns, developers can save time and effort by reusing proven solutions rather than creating new ones from scratch.

Overall, design patterns can help developers create more efficient, maintainable, and scalable software systems, by providing proven solutions to common problems encountered in the development process.

## Structural Patterns

Structural patterns are a category of design patterns that are concerned with the composition of classes and objects. These patterns are used to create relationships between different objects, allowing them to work together in a coordinated and efficient manner.

Structural patterns typically involve the use of inheritance and composition to create complex object structures. They are used to solve problems related to object composition, such as how to create object hierarchies, how to create complex objects from simpler ones, and how to make objects work together to achieve a common goal.
> <a href="#-Adapter_Anchor"> Adapter Pattern </a> <br/>
> Bridge Pattern <br/>
> Filter Pattern <br/>
> Composite Pattern <br/>
> Decorator Pattern <br/>
> Facade Pattern <br/>
> Flweight Patter <br/>
> Proxy Pattern <br/>

## Behavioral Patterns

Behavioral patterns are design patterns that deal with the behavior and communication between objects. They focus on the interactions between objects and how they operate together to achieve a certain goal.

Overall, behavioral patterns are useful for creating flexible and maintainable systems by separating the behavior and responsibilities of objects, and allowing them to interact in a clear and understandable way.

> <a href="#ChainOfResponsibility_Anchor"> Chain of Responsibility </a> <br/>
> Command Pattern <br/>
> Iterator Pattern <br/>
> Mediator  Pattern <br/>
> Memento Pattern <br/>
> Observer Patter <br/>
> State Pattern <br/>
> Strategy Pattern <br/>
> Visitor Pattern <br/>

## Creational Patterns

Creational patterns are a type of design pattern that deal with object creation mechanisms, trying to create objects in a manner suitable to the situation. They provide a way to create objects while hiding the creation logic, making the code more flexible and easier to maintain.

Overall, creational patterns are useful for creating flexible and maintainable systems by separating the responsibilities of object creation from the rest of the code, and providing a clear and consistent way to create new objects.

> <a name="#ChainOfResponsibility_Anchor"> Singleton Pattern </a> <br/>
> Factory Method Pattern <br/>
> Iterator Pattern <br/>
> Abstract Factory Pattern <br/>
> Builder   Pattern <br/>
> Prototype  Pattern <br/>

### <div id="Adapter_Anchor"> Adapter Pattern</div>

The Adapter pattern is a structural design pattern that allows incompatible objects to collaborate. It acts as a bridge between two incompatible interfaces, allowing them to work together without the need to modify their source code.

The Adapter pattern is particularly useful when you need to integrate an existing class into a new system or when you want to use an existing class that doesn't have the interface you need.

The pattern involves creating a new adapter class that implements the required interface and adapts the methods of the incompatible class to the new interface. The adapter class acts as a translator, converting the method calls from the new system into calls that the incompatible class can understand.
