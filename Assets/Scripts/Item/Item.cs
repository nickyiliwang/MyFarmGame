using UnityEngine;

public class Item : MonoBehaviour
{
    [ItemCodeDescription] // custom field
    [SerializeField]
    private int _itemCode;

    private SpriteRenderer spriteRenderer;

    public int ItemCode
    {
        get { return _itemCode; }
        set { _itemCode = value; }
    }

    private void Awake()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void Start()
    {
        if (ItemCode != 0)
        {
            InitItemBehavior(ItemCode);
        }
    }

    public void InitItemBehavior(int itemCodeParam)
    {
        if (itemCodeParam != 0)
        {
            ItemCode = itemCodeParam;

            ItemDetails itemDetails = InventoryManager.Instance.GetItemDetails(ItemCode);
            spriteRenderer.sprite = itemDetails.itemSprite;

            // If item type is reapable then add nudge component
            if (itemDetails.itemType == ItemType.Reapable_scenery)
            {
                gameObject.AddComponent<ItemNudge>();
            }
        }
    }
}
