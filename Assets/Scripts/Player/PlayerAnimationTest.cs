using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationTest : MonoBehaviour
{
    [SerializeField]
    public AnimationSettings PlayerSettings = new AnimationSettings();

    private void Update()
    {
        EventHandler.CallMovementEvent(PlayerSettings);
    }
}
