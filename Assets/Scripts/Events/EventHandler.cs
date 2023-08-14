public delegate void MovementDelegate(AnimationSettings serializedClass);

public class EventHandler
{
    // Movement Event
    public static event MovementDelegate MovementEvent;

    // Movement Event Call For Publisher
    public static void CallMovementEvent(AnimationSettings playerSettings)
    {
        if (MovementEvent != null)
        {
            MovementEvent(playerSettings);
        }
    }
}


// Used to handle player movement events. Other components or scripts in the game can subscribe to the MovementEvent event and be notified when the player's movement changes.
