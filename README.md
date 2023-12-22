# Adapter Design Pattern in C#

This repository contains a simple implementation of the Adapter design pattern in C#.

## Table of Contents

- [Description](#description)
- [Usage](#usage)
- [Implementation Details](#implementation-details)

## Description

The Adapter design pattern allows the interface of an existing class to be used as another interface. It is often used to make existing classes work with others without modifying their source code.

In this implementation:

- **`ITarget` Interface:** Represents the target interface that the client expects.
- **`Adapter` Class:** Adapts the `Adaptee` class to work with the `ITarget` interface.
- **`Adaptee` Class:** The class that needs to be adapted.

## Usage

To use the Adapter pattern:

1. Create an instance of the `Adaptee` class.
2. Create an instance of the `Adapter` class, passing the `Adaptee` instance to its constructor.
3. Use the `ITarget` interface to make requests.

Example:

```csharp
Adaptee adaptee = new Adaptee();
ITarget target = new Adapter(adaptee);
target.Request();
```

## Implementation Details

### `ITarget` Interface:

The `ITarget` interface declares the target interface that the client code expects. It typically includes one or more methods that the client can invoke.

### `Adapter` Class:

The `Adapter` class is responsible for adapting the `Adaptee` class to the `ITarget` interface. Here are the key details:

- **Constructor:**
  - The class has a constructor that takes an instance of the `Adaptee` class, establishing a connection between the adapter and the adaptee.

- **`Request` Method Implementation:**
  - The `Request` method is implemented to delegate the request to the `SpecificRequest` method of the encapsulated `Adaptee` instance.

### `Adaptee` Class:

The `Adaptee` class represents the existing class that needs to be adapted. It contains the specific functionality that the client code wants to use through the `ITarget` interface.

- **`SpecificRequest` Method:**
  - The class includes a method called `SpecificRequest`, which represents the specific functionality provided by the `Adaptee`.
