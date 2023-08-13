﻿using System;
using UnityEngine;

// Subscription
public class MovementAnimationParameterControl : MonoBehaviour
{
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

    private void SetAnimationParameters(
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
        animator.SetInteger(Settings.toolEffect, (int)toolEffect);

        animator.SetFloat(Settings.inputX, inputX);
        animator.SetFloat(Settings.inputY, inputY);
        animator.SetBool(Settings.isWalking, isWalking);
        animator.SetBool(Settings.isRunning, isRunning);

        if (isUsingToolLeft)
            animator.SetTrigger(Settings.isUsingToolLeft);
        if (isUsingToolRight)
            animator.SetTrigger(Settings.isUsingToolRight);
        if (isUsingToolUp)
            animator.SetTrigger(Settings.isUsingToolUp);
        if (isUsingToolDown)
            animator.SetTrigger(Settings.isUsingToolDown);
        if (isLiftingToolLeft)
            animator.SetTrigger(Settings.isLiftingToolLeft);
        if (isLiftingToolRight)
            animator.SetTrigger(Settings.isLiftingToolRight);
        if (isLiftingToolUp)
            animator.SetTrigger(Settings.isLiftingToolUp);
        if (isLiftingToolDown)
            animator.SetTrigger(Settings.isLiftingToolDown);
        if (isPickingLeft)
            animator.SetTrigger(Settings.isPickingLeft);
        if (isPickingRight)
            animator.SetTrigger(Settings.isPickingRight);
        if (isPickingUp)
            animator.SetTrigger(Settings.isPickingUp);
        if (isPickingDown)
            animator.SetTrigger(Settings.isPickingDown);
        if (isSwingingToolLeft)
            animator.SetTrigger(Settings.isSwingingToolLeft);
        if (isSwingingToolRight)
            animator.SetTrigger(Settings.isSwingingToolRight);
        if (isSwingingToolUp)
            animator.SetTrigger(Settings.isSwingingToolUp);
        if (isSwingingToolDown)
            animator.SetTrigger(Settings.isSwingingToolDown);
        if (idleLeft)
            animator.SetTrigger(Settings.idleLeft);
        if (idleRight)
            animator.SetTrigger(Settings.idleRight);
        if (idleUp)
            animator.SetTrigger(Settings.idleUp);
        if (idleDown)
            animator.SetTrigger(Settings.idleDown);
    }

    private void AnimationEventPlayFootStepSound() { }
}
