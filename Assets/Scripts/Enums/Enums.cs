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

// ## enum fundamentals
// an enum (short for enumeration) is a data type that represents a set of named constant values. It is used to define a collection of related values that can be assigned to a variable.

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

// ## The purpose of count in enums

// In the given code snippet, the count enum value does not serve any specific functionality.

// The purpose of including a count enum value in this context is to indicate the total number of elements in the InventoryLocation enum. It is often used as a convention to simplify certain operations or loops that require iterating over all the values in an enum.

// For example, if you have a scenario where you need to iterate over all the possible inventory locations, including the player and chest, you can use the count enum value to determine the total number of elements in the InventoryLocation enum. Here's an example:

// for (int i = 0; i < (int)InventoryLocation.count; i++)
// {
//     InventoryLocation location = (InventoryLocation)i;
//     // Perform operations for each inventory location
// }
// By using (int)InventoryLocation.count, you can easily determine the total number of elements in the enum and use it as the condition for your loop. Note that the count value should always be the last element in the enum definition to ensure accurate counting.

// Although it's not strictly necessary to include a count value in every enum, it can be helpful in scenarios where you want to iterate over all the enum values without hard-coding the total count.
