﻿using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Item item = collision.GetComponent<Item>();

        if (item != null)
        {
            // Get item details
            ItemDetails itemDetails = InventoryManager.Instance.GetItemDetails(item.ItemCode);

            // if the item can be picked up
            if (itemDetails.canBePickedUp == true)
            {
                // Add item to inventory
                InventoryManager.Instance.AddItemThenDeleteGO(
                    InventoryLocation.player,
                    item,
                    collision.gameObject
                );
            }
        }
    }
}
