public enum InventoryLocation
{
    player,
    chest,
    count
}

public enum ToolEffect
{
    none,
    watering
}

public enum Direction
{
    none,
    up,
    down,
    left,
    right
}

public enum ItemType
{
    Seed,
    Commodity,
    Watering_tool,
    Hoeing_tool,
    Chopping_tool,
    Breaking_tool,
    Reaping_tool,
    Collecting_tool,
    Reapable_scenery,
    Furniture,
    none,
    count
}


// an enum (short for enumeration) is a data type that represents a set of named constant values. It is used to define a collection of related values that can be assigned to a variable.

// In the specific case you mentioned, public enum InventoryLocation is declaring an enum called InventoryLocation with a public access modifier. This means that the enum can be accessed from outside the class or file it is declared in.

// For example, consider the following code:
// public enum InventoryLocation
// {
//     Warehouse,
//     Store,
//     Online
// }

// In this code, the InventoryLocation enum is public, so it can be used and accessed by other classes or files. The enum defines three constant values: Warehouse, Store, and Online. These values can be assigned to a variable of type InventoryLocation, like this:

// InventoryLocation location = InventoryLocation.Store;

// Using an enum can make your code more readable and maintainable, as it provides a way to represent a limited set of options or states in a concise and self-explanatory manner.
