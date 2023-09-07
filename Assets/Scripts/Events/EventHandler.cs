using System;
using System.Collections.Generic;

public delegate void MovementDelegate(AnimationSettings serializedClass);

public class EventHandler
{
    // Inventory updated event
    public static event Action<InventoryLocation>

    // Movement Event
    public static event MovementDelegate MovementEvent;

    // Movement Event Call For Publisher
    public static void CallMovementEvent(AnimationSettings playerSettings)
    {
        MovementEvent?.Invoke(playerSettings);
    }
}


// Used to handle player movement events. Other components or scripts in the game can subscribe to the MovementEvent event and be notified when the player's movement changes.


// MovementEvent?.Invoke(playerSettings)
// Shorthand for:
// if (MovementEvent != null)
// {
//     MovementEvent(playerSettings);
// }


// In C# and Unity, the Action is a predefined delegate type that represents a method that doesn't return a value (void) and can take zero or more parameters. It can be used to define and invoke callbacks or event handlers.

// The Action delegate can be declared with up to 16 generic parameters, depending on the number of parameters the method it represents should accept. For example: