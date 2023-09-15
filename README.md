# Prototype-Design-Pattern-Demo

This project demonstrates the Prototype design pattern in C#. The Prototype Pattern is a creational design pattern that allows you to create new objects by copying an existing object, known as the prototype. It is particularly useful when you want to create objects without knowing their concrete classes and when you need to avoid creating subclasses in the client program.

## Introduction
The Prototype Pattern is one of the creational design patterns that provides a way to create new objects based on an existing object. In this project, we've implemented the Prototype Pattern using C# to demonstrate two types of cloning:

- Shallow Clone: The GetShallowClone() method creates a new object that is a shallow copy of the original object. This means that reference type properties inside the cloned object will point to the same memory address as the original object.

- Deep Clone: The GetDeepClone() method creates a new object that is a deep copy of the original object. In a deep copy, the cloned object and the original object's properties will point to completely different memory addresses.

## Use Case
The Prototype Pattern becomes particularly useful when you need to:

Create an exact clone of an object without knowing its concrete implementation.
Copy private fields of an object.
Avoid depending on the concrete implementation of the original class when working with cloned objects.

## Design Diagram
The design diagram of the prototype pattern is as follows:

![](./image-4.png)


## How to Implement the Prototype Design Pattern

To implement the Prototype Design Pattern, follow these steps:

Create an interface, such as IPlayer, that defines methods for cloning objects.
Implement the IPlayer interface in concrete classes, such as Player, providing both shallow and deep cloning methods.
Use the prototype pattern to create new objects based on the existing objects.
Project Structure
The project is organized as follows:

IPlayer.cs: Defines the IPlayer interface with GetShallowClone() and GetDeepClone() methods.
Player.cs: Implements the IPlayer interface and provides a concrete player class with name and stats.
Stats.cs: Defines the Stats class.
UnitTest1.cs: Contains unit tests for the Player class.

## Usage
You can use this Prototype Pattern implementation as follows:

Create a new player object using the Player class, providing a name and stats.
Use the GetShallowClone() method to create a shallow copy of the player object.
Use the GetDeepClone() method to create a deep copy of the player object.

## Unit Tests
The project includes unit tests to ensure the correctness of the cloning methods. You can run these tests to verify the behavior of the Prototype Pattern implementation.

