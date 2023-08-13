public delegate void MovementDelegate(
    ToolEffect toolEffect,
    float inputX,
    float inputY,
    bool isWalking,
    bool isRunning,
    bool isIdle,
    bool isCarrying,
    bool isUsingTool,
    bool isUsingToolLeft,
    bool isUsingToolRight,
    bool isUsingToolUp,
    bool isUsingToolDown,
    bool isLiftingToolLeft,
    bool isLiftingToolRight,
    bool isLiftingToolUp,
    bool isLiftingToolDown,
    bool isPickingLeft,
    bool isPickingRight,
    bool isPickingUp,
    bool isPickingDown,
    bool isSwingingToolLeft,
    bool isSwingingToolRight,
    bool isSwingingToolUp,
    bool isSwingingToolDown,
    bool idleLeft,
    bool idleRight,
    bool idleUp,
    bool idleDown
);

public class EventHandler
{
    // Movement Event
    public static event MovementDelegate MovementEvent;

    // Movement Event Call For Publisher
    public static void CallMovementEvent(
        ToolEffect toolEffect,
        float inputX,
        float inputY,
        bool isWalking,
        bool isRunning,
        bool isIdle,
        bool isCarrying,
        bool isUsingTool,
        bool isUsingToolLeft,
        bool isUsingToolRight,
        bool isUsingToolUp,
        bool isUsingToolDown,
        bool isLiftingToolLeft,
        bool isLiftingToolRight,
        bool isLiftingToolUp,
        bool isLiftingToolDown,
        bool isPickingLeft,
        bool isPickingRight,
        bool isPickingUp,
        bool isPickingDown,
        bool isSwingingToolLeft,
        bool isSwingingToolRight,
        bool isSwingingToolUp,
        bool isSwingingToolDown,
        bool idleLeft,
        bool idleRight,
        bool idleUp,
        bool idleDown
    )
    {
        if (MovementEvent != null)
        {
            MovementEvent(
                toolEffect,
                inputX,
                inputY,
                isWalking,
                isRunning,
                isIdle,
                isCarrying,
                isUsingTool,
                isUsingToolLeft,
                isUsingToolRight,
                isUsingToolUp,
                isUsingToolDown,
                isLiftingToolLeft,
                isLiftingToolRight,
                isLiftingToolUp,
                isLiftingToolDown,
                isPickingLeft,
                isPickingRight,
                isPickingUp,
                isPickingDown,
                isSwingingToolLeft,
                isSwingingToolRight,
                isSwingingToolUp,
                isSwingingToolDown,
                idleLeft,
                idleRight,
                idleUp,
                idleDown
            );
        }
    }
}


// Used to handle player movement events. Other components or scripts in the game can subscribe to the MovementEvent event and be notified when the player's movement changes.
