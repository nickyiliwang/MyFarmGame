using System;

[Serializable]
public struct InventoryItem
{
    public int itemCode;
    public int itemQuantity;
}


// Structs are often used when a lightweight, stack-allocated data structure is needed. Unlike classes, structs are value types, so they are passed by value rather than by reference. This means that when you assign a struct variable to another, a copy of the entire struct is made.

// Yes, a struct is similar to a class in many ways. Both structs and classes are used to define custom data types and both can have fields, properties, methods, and other members.

// However, there are some important differences between structs and classes:

// Value Type vs Reference Type: Structs are value types, while classes are reference types. This means that when you assign a struct to another variable or pass it as a parameter, a copy of the entire struct is made. On the other hand, when you assign a class instance to another variable or pass it as a parameter, you're actually passing a reference to the same object.

// Memory Allocation: Structs are usually stack-allocated, whereas objects of a class are heap-allocated. This makes structs more lightweight and efficient in terms of memory usage.

// Inheritance: Structs cannot inherit from other structs or classes, and they cannot be base classes for any other type. Classes, on the other hand, can be inherited from and used as base classes.

// Default Constructor: Unlike classes, structs do not have a default constructor automatically provided by the compiler. If you want to create a parameterless constructor for a struct, you need to define it explicitly.

// Nullable Values: Structs can be marked as nullable using the "?" operator, allowing them to represent null values. Classes are already nullable by default.

// In summary, while structs and classes share some similarities, they also have important differences in terms of behavior and usage. It's important to consider these differences when deciding whether to use a struct or a class for a specific scenario.
