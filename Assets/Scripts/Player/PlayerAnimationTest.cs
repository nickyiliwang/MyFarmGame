using UnityEngine;

public class PlayerAnimationTest : MonoBehaviour
{
    [SerializeField]
    public AnimationSettings playerSettings = new AnimationSettings();

    private void Update()
    {
        EventHandler.CallMovementEvent(playerSettings);
    }
}
