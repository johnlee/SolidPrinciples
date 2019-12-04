# README #

SOLID Principles

## S - Single Responsibility Principle ##
We want methods and classes to focus on specific functions. We dont want it to do too many things. This causes inner-dependencies that can increase complexity. In other words, we want to high decoupling and low cohesion.

## O - Open Closed Principle ##
Keep classes open for extension but closed for modifications. We dont want the core functionality of a class to change, however, certain properties of a class should be easily extendable.

## L - Liskov Substitution Principle ##
Use derived classes. Dont always use base classes. Use interfaces. For example, create an IRepository that classes can interface with. Behind that IRepository is the different implementations but that should not be shown to the classes referencing it. The interface has the core functionality exposed.

## I - Interface Segragation Principle ##
Make fine grained interfaces that is specific to the function. This way no client or calling class needs to have access to unnecessary/unused functions in an interface.

## D - Dependency Inversion Principle ##
Use abstractions and not concrete implementations. The concrete implementations get injected at run-time. Clients interact via these abstractions. This allows for flexibility in how the concrete implementations are conducted.
