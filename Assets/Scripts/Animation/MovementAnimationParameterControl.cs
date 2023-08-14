using UnityEngine;

// Subscription
public class MovementAnimationParameterControl : MonoBehaviour
{
    private void AnimationEventPlayFootstepSound() { }

    private Animator animator; // Interface to control the animation system

    // initialization

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        EventHandler.MovementEvent += SetAnimationParameters;
    }

    private void OnDisable()
    {
        EventHandler.MovementEvent -= SetAnimationParameters;
    }

    private void SetAnimationParameters(AnimationSettings playerSettings)
    {
        AnimationSettingsHash playerSettingsHash = new AnimationSettingsHash();

        animator.SetInteger(playerSettingsHash.toolEffect, (int)playerSettings.toolEffect);

        animator.SetFloat(playerSettingsHash.xInput, playerSettings.xInput);
        animator.SetFloat(playerSettingsHash.yInput, playerSettings.yInput);
        animator.SetBool(playerSettingsHash.isWalking, playerSettings.isWalking);
        animator.SetBool(playerSettingsHash.isRunning, playerSettings.isRunning);

        if (playerSettings.isUsingToolLeft)
            animator.SetTrigger(playerSettingsHash.isUsingToolLeft);
        if (playerSettings.isUsingToolRight)
            animator.SetTrigger(playerSettingsHash.isUsingToolRight);
        if (playerSettings.isUsingToolUp)
            animator.SetTrigger(playerSettingsHash.isUsingToolUp);
        if (playerSettings.isUsingToolDown)
            animator.SetTrigger(playerSettingsHash.isUsingToolDown);
        if (playerSettings.isLiftingToolLeft)
            animator.SetTrigger(playerSettingsHash.isLiftingToolLeft);
        if (playerSettings.isLiftingToolRight)
            animator.SetTrigger(playerSettingsHash.isLiftingToolRight);
        if (playerSettings.isLiftingToolUp)
            animator.SetTrigger(playerSettingsHash.isLiftingToolUp);
        if (playerSettings.isLiftingToolDown)
            animator.SetTrigger(playerSettingsHash.isLiftingToolDown);
        if (playerSettings.isPickingLeft)
            animator.SetTrigger(playerSettingsHash.isPickingLeft);
        if (playerSettings.isPickingRight)
            animator.SetTrigger(playerSettingsHash.isPickingRight);
        if (playerSettings.isPickingUp)
            animator.SetTrigger(playerSettingsHash.isPickingUp);
        if (playerSettings.isPickingDown)
            animator.SetTrigger(playerSettingsHash.isPickingDown);
        if (playerSettings.isSwingingToolLeft)
            animator.SetTrigger(playerSettingsHash.isSwingingToolLeft);
        if (playerSettings.isSwingingToolRight)
            animator.SetTrigger(playerSettingsHash.isSwingingToolRight);
        if (playerSettings.isSwingingToolUp)
            animator.SetTrigger(playerSettingsHash.isSwingingToolUp);
        if (playerSettings.isSwingingToolDown)
            animator.SetTrigger(playerSettingsHash.isSwingingToolDown);
        if (playerSettings.isIdleLeft)
            animator.SetTrigger(playerSettingsHash.idleLeft);
        if (playerSettings.isIdleRight)
            animator.SetTrigger(playerSettingsHash.idleRight);
        if (playerSettings.isIdleUp)
            animator.SetTrigger(playerSettingsHash.idleUp);
        if (playerSettings.isIdleDown)
            animator.SetTrigger(playerSettingsHash.idleDown);
    }
}
