using System;
using UnityEngine;

[Serializable]
public class AnimationSettings
{
    public int xInput,
        yInput;
    public bool isWalking,
        isRunning;
    public ToolEffect toolEffect;
    public bool isUsingToolRight,
        isUsingToolLeft,
        isUsingToolUp,
        isUsingToolDown;
    public bool isLiftingToolRight,
        isLiftingToolLeft,
        isLiftingToolUp,
        isLiftingToolDown;
    public bool isPickingLeft,
        isPickingRight,
        isPickingUp,
        isPickingDown;
    public bool isSwingingToolLeft,
        isSwingingToolRight,
        isSwingingToolUp,
        isSwingingToolDown;
    public bool isIdleLeft,
        isIdleRight,
        isIdleUp,
        isIdleDown;
}

[Serializable]
public class AnimationSettingsHash
{
    public int toolEffect = Animator.StringToHash("toolEffect");
    public int xInput = Animator.StringToHash("xInput");
    public int yInput = Animator.StringToHash("yInput");
    public int isWalking = Animator.StringToHash("isWalking");
    public int isRunning = Animator.StringToHash("isRunning");
    public int isIdle = Animator.StringToHash("isIdle");
    public int isCarrying = Animator.StringToHash("isCarrying");
    public int isUsingTool = Animator.StringToHash("isUsingTool");
    public int isUsingToolLeft = Animator.StringToHash("isUsingToolLeft");
    public int isUsingToolRight = Animator.StringToHash("isUsingToolRight");
    public int isUsingToolUp = Animator.StringToHash("isUsingToolUp");
    public int isUsingToolDown = Animator.StringToHash("isUsingToolDown");
    public int isLiftingToolLeft = Animator.StringToHash("isLiftingToolLeft");
    public int isLiftingToolRight = Animator.StringToHash("isLiftingToolRight");
    public int isLiftingToolUp = Animator.StringToHash("isLiftingToolUp");
    public int isLiftingToolDown = Animator.StringToHash("isLiftingToolDown");
    public int isPickingLeft = Animator.StringToHash("isPickingLeft");
    public int isPickingRight = Animator.StringToHash("isPickingRight");
    public int isPickingUp = Animator.StringToHash("isPickingUp");
    public int isPickingDown = Animator.StringToHash("isPickingDown");
    public int isSwingingToolLeft = Animator.StringToHash("isSwingingToolLeft");
    public int isSwingingToolRight = Animator.StringToHash("isSwingingToolRight");
    public int isSwingingToolUp = Animator.StringToHash("isSwingingToolUp");
    public int isSwingingToolDown = Animator.StringToHash("isSwingingToolDown");
    public int idleLeft = Animator.StringToHash("idleLeft");
    public int idleRight = Animator.StringToHash("idleRight");
    public int idleUp = Animator.StringToHash("idleUp");
    public int idleDown = Animator.StringToHash("idleDown");
}