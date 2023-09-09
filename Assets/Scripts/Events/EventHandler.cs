using System;
using System.Collections.Generic;

public delegate void MovementDelegate(AnimationSettings serializedClass);

public class EventHandler
{
    // Inventory Event
    public static event Action<InventoryLocation, List<InventoryItem>> InventoryUpdatedEvent;

    public static void CallInventoryUpdatedEvent(
        InventoryLocation inventoryLocation,
        List<InventoryItem> inventoryList
    )
    {
        InventoryUpdatedEvent?.Invoke(inventoryLocation, inventoryList);
    }

    // Movement Event
    public static event MovementDelegate MovementEvent;

    public static void CallMovementEvent(AnimationSettings playerSettings)
    {
        MovementEvent?.Invoke(playerSettings);
    }
}

// More about pub sub and event handling in README.md

// Used to handle player movement events. Other components or scripts in the game can subscribe to the MovementEvent event and be notified when the player's movement changes.

// Action
// In C# and Unity, the Action is a predefined delegate type that represents a method that doesn't return a value (void) and can take zero or more parameters. It can be used to define and invoke callbacks or event handlers.

// The Action delegate can be declared with up to 16 generic parameters, depending on the number of parameters the method it represents should accept.

// public Action<int, string> myCallback;
// Here, myCallback is an Action that takes an int and a string as parameters. Similarly, you can assign a method or a lambda expression with matching parameter types to this variable.

// Using the Action delegate can be useful when you want to define and pass around methods as arguments or store them for later execution, especially in scenarios like event handling or asynchronous programming.
