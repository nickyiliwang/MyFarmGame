using UnityEngine;

public class InventoryBar : MonoBehaviour
{
    private RectTransform rectTransform;

    // TODO, fade the menu instead of moving it.
    // private SpriteRenderer spriteRenderer;

    private bool isInventoryBarPositionBottom;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        // spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        SwitchInventoryBarPosition();
    }

    private void SwitchInventoryBarPosition()
    {
        Vector3 playerViewportPosition = Player.Instance.GetPlayerViewPortPosition();

        if (playerViewportPosition.y > 0.3f && isInventoryBarPositionBottom == false)
        {
            // transform.position = new Vector3(transform.position.x, 7.5f, 0f);
            rectTransform.pivot = new Vector2(0.5f, 0f);
            rectTransform.anchorMin = new Vector2(0.5f, 0f);
            rectTransform.anchorMax = new Vector2(0.5f, 0f);
            rectTransform.anchoredPosition = new Vector2(0f, 2.5f);

            isInventoryBarPositionBottom = true;
        }
        else if (playerViewportPosition.y <= 0.3f && isInventoryBarPositionBottom == true)
        {
            rectTransform.pivot = new Vector2(0.5f, 1f);
            rectTransform.anchorMin = new Vector2(0.5f, 1f);
            rectTransform.anchorMax = new Vector2(0.5f, 1f);
            rectTransform.anchoredPosition = new Vector2(0f, -2.5f);

            isInventoryBarPositionBottom = false;
        }
    }
}
