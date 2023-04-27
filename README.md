# Design Patterns

Design patterns refer to reusable solutions to common problems that occur during software design and development. These patterns have been identified and documented by experts in the field of software development and are intended to help developers create robust and maintainable software systems.

Design patterns are typically used to solve common problems that occur during the development process, such as object creation, object relationships, algorithm design, and communication between objects. By using these patterns, developers can save time and effort by reusing proven solutions rather than creating new ones from scratch.

Overall, design patterns can help developers create more efficient, maintainable, and scalable software systems, by providing proven solutions to common problems encountered in the development process.

## Structural Patterns

Structural patterns are a category of design patterns that are concerned with the composition of classes and objects. These patterns are used to create relationships between different objects, allowing them to work together in a coordinated and efficient manner.

Structural patterns typically involve the use of inheritance and composition to create complex object structures. They are used to solve problems related to object composition, such as how to create object hierarchies, how to create complex objects from simpler ones, and how to make objects work together to achieve a common goal.
> <a href="#AdapterAnchor">Adapter Pattern</a> <br/>
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

> <a name="#Chain_Anchor"> Singleton Pattern </a> <br/>
> Factory Method Pattern <br/>
> Iterator Pattern <br/>
> Abstract Factory Pattern <br/>
> Builder   Pattern <br/>
> Prototype  Pattern <br/>

### <a name="AdapterAnchor"/> Adapter Pattern

The Adapter pattern is a structural design pattern that allows incompatible objects to collaborate. It acts as a bridge between two incompatible interfaces, allowing them to work together without the need to modify their source code.

The Adapter pattern is particularly useful when you need to integrate an existing class into a new system or when you want to use an existing class that doesn't have the interface you need.

The pattern involves creating a new adapter class that implements the required interface and adapts the methods of the incompatible class to the new interface. The adapter class acts as a translator, converting the method calls from the new system into calls that the incompatible class can understand.

### Singleton Pattern

Singleton pattern is a creational design pattern that ensures a class has only one instance, while providing a global point of access to this instance. This means that there is a single instance of the class, and all clients that need to use the class will use this same instance. The purpose of the Singleton pattern is to control object creation, limiting the number of instances to one and providing a way to access that instance globally.

This pattern is useful when we need to ensure that there is only one instance of a class throughout the lifetime of an application. Examples of this could include a logging service, a database connection, or a configuration manager. In these cases, having multiple instances of the class could cause issues such as conflicting data, performance problems, or increased memory usage.

To implement the Singleton pattern, we typically use a private constructor to prevent direct instantiation of the class, a private static variable to hold the single instance of the class, and a public static method to provide access to this instance. The public static method checks if an instance already exists and returns it if it does, or creates a new instance if it does not. This ensures that only one instance of the class exists and is used throughout the application.

### Strategy Pattern

The strategy pattern is a behavioral design pattern that enables the selection of an algorithm at runtime from a family of related algorithms. It allows clients to choose the algorithm that best suits their needs and to switch between them easily. The strategy pattern is particularly useful when there are several interchangeable variations of an algorithm, which can be encapsulated in a set of classes implementing a common interface.

In summary, the strategy pattern provides a flexible and dynamic way to encapsulate algorithm behavior, making it easier to maintain and extend code over time.

### Builder Pattern

The Builder pattern is a creational design pattern that allows you to create complex objects step by step. It separates the construction of an object from its representation, making it easier to create and customize different representations of the same object.

### Observer Pattern

Observer design pattern is a behavioral pattern that defines a one-to-many dependency between objects, where a change in one object (the subject) will notify all of its dependents (observers) and update them automatically. The observer pattern is used when we need to maintain consistency between related objects without tightly coupling them.
