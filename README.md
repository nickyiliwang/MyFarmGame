# MyFarmGame

Educational Assets, please do not use any of the Assets in your projects, the script are okay lol

## Notes

<!-- Design patterns -->

### Singleton MonoBehaviour

Any game object will only exist once in this pattern

### Pub Sub

In CSharp Delegates and events, actions
Refer to /Archive/Events+and+Event+Handler
used for cases such as movement
+= to subscribe

<!-- Code example -->

EventHandler => Settings => MovementAnimationParameterControl

- Event handler: creates the delegate and event method, acting as a proxy for a publisher to use

- Settings: makes string into hash for efficiency

- MovementAnimationParameterControl: Subscribes to the movement events on enable and set triggers for when each movement is changed, this will then control the animations.

- PlayerAnimationTest is the real publisher, everything changed on there will be published to the subscribers and trigger animations

