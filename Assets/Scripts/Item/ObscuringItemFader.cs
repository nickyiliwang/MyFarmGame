using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))] // Game objects like trees
public class ObscuringItemFader : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public void FadeIn()
    {
        // create functions that can pause and resume their execution
        // Coroutines in Unity and C# are commonly used for tasks such as delaying actions, performing animations, or implementing timed sequences of events. They provide a convenient way to handle asynchronous behavior without the complexity of multithreading or callbacks.
        // In this case i think the fading out/in animations are the delaying actions
        StartCoroutine(FadeInRoutine());
    }

    public void FadeOut()
    {
        StartCoroutine(FadeOutRoutine());
    }

    private IEnumerator FadeInRoutine()
    {
        float currentAlpha = spriteRenderer.color.a;
        float alphaDifference = 1f - currentAlpha;

        while (1f - currentAlpha + alphaDifference / Settings.fadeInSeconds > 0.01f)
        {
            // By including the alpha difference and dividing it by the fade-in duration along with the current alpha value, it ensures that the rate at which the alpha value increases gradually slows down as it approaches 1
            currentAlpha += alphaDifference / Settings.fadoOutSeconds * Time.deltaTime;
            spriteRenderer.color = new Color(1f, 1f, 1f, currentAlpha);
            // Using yield return null is often used in situations where you want to smoothly animate something over time or update a continuous operation without blocking the main thread.
            yield return null;
        }

        spriteRenderer.color = new Color(1f, 1f, 1f, 1f);
    }

    private IEnumerator FadeOutRoutine()
    {
        float currentAlpha = spriteRenderer.color.a;
        float alphaDifference = currentAlpha - Settings.targetAlpha;

        while (currentAlpha - Settings.targetAlpha > 0.01f)
        {
            currentAlpha -= alphaDifference / Settings.fadoOutSeconds * Time.deltaTime;
            spriteRenderer.color = new Color(1f, 1f, 1f, currentAlpha);
            yield return null;
        }

        spriteRenderer.color = new Color(1f, 1f, 1f, Settings.targetAlpha);
    }
}
