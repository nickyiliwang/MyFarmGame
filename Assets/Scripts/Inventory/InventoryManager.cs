using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : SingletonMonoBehaviour<InventoryManager>
{
    private Dictionary<int, ItemDetails> itemDetailsDictionary;

    public List<InventoryItem>[] inventoryLists;

    [HideInInspector]
    public int[] inventoryListCapacityIntArray; // the index of the array is the inventory list (from the InventoryLocation enum), and the value is the capacity of that inventory list

    [SerializeField]
    private SO_ItemList itemList = null;

    protected override void Awake()
    {
        base.Awake();

        CreateInventoryLists();

        // Create item details dictionary
        CreateItemDetailsDictionary();
    }

    private void CreateInventoryLists()
    {
        inventoryLists = new List<InventoryItem>[(int)InventoryLocation.count];

        for (int i = 0; i < (int)InventoryLocation.count; i++)
        {
            inventoryLists[i] = new List<InventoryItem>();
        }

        // initialize inventory list capacity array
        // ************
        // int[] numbers;

        // numbers= new int[2];

        // numbers[(int)0] = 32;

        // Console.WriteLine(numbers[0]);
        // ************
        inventoryListCapacityIntArray = new int[(int)InventoryLocation.count];

        // initialize player inventory list capacity
        inventoryListCapacityIntArray[(int)InventoryLocation.player] =
            Settings.playerInitialInventoryCapacity;
    }

    // Populates the itemDetailsDictionary from the scriptable object items list
    private void CreateItemDetailsDictionary()
    {
        itemDetailsDictionary = new Dictionary<int, ItemDetails>();

        foreach (ItemDetails itemDetails in itemList.itemDetails)
        {
            itemDetailsDictionary.Add(itemDetails.itemCode, itemDetails);
        }
    }

    public void AddItemThenDeleteGO(
        InventoryLocation inventoryLocation,
        Item item,
        GameObject gameObjectToDelete
    )
    {
        AddItemToInventory(inventoryLocation, item);
        Destroy(gameObjectToDelete);
    }

    // Add an item to the inventory list for the inventoryLocation
    public void AddItemToInventory(InventoryLocation inventoryLocation, Item item)
    {
        int itemCode = item.ItemCode;
        List<InventoryItem> inventoryList = inventoryLists[(int)inventoryLocation];

        // check if inventory already contains the item
        int itemPosition = FindItemInInventory(inventoryLocation, itemCode);

        if (itemPosition != -1)
        {
            AddExistingItem(inventoryList, itemCode, itemPosition);
        }
        else
        {
            AddNewItem(inventoryList, itemCode);
        }
        ;

        // Send event that inventory has been updated
        EventHandler.CallInventoryUpdatedEvent(
            inventoryLocation,
            inventoryLists[(int)inventoryLocation]
        );
    }

    private void AddExistingItem(List<InventoryItem> inventoryList, int itemCode, int itemPosition)
    {
        int quantity = inventoryList[itemPosition].itemQuantity + 1;
        InventoryItem inventoryItem = new InventoryItem()
        {
            itemCode = itemCode,
            itemQuantity = quantity
        };

        inventoryList[itemPosition] = inventoryItem;

        DebugPrintInventoryList(inventoryList);
    }

    private void AddNewItem(List<InventoryItem> inventoryList, int itemCode)
    {
        InventoryItem inventoryItem = new InventoryItem() { itemCode = itemCode, itemQuantity = 1 };

        inventoryList.Add(inventoryItem);

        DebugPrintInventoryList(inventoryList);
    }

    public int FindItemInInventory(InventoryLocation inventoryLocation, int itemCode)
    {
        List<InventoryItem> inventoryList = inventoryLists[(int)inventoryLocation];
        return inventoryList.FindIndex(item => item.itemCode == itemCode);
    }

    // Return the itemDetails (from the SO_ItemList) for the itemCode, or null if the item code doesn't exist
    public ItemDetails GetItemDetails(int itemCode)
    {
        ItemDetails itemDetails;

        if (itemDetailsDictionary.TryGetValue(itemCode, out itemDetails))
        {
            return itemDetails;
        }
        else
        {
            return null;
        }
    }

    private void DebugPrintInventoryList(List<InventoryItem> inventoryList)
    {
        foreach (InventoryItem inventoryItem in inventoryList)
        {
            Debug.Log(
                "Item Description:"
                    + Instance.GetItemDetails(inventoryItem.itemCode).itemDescription
                    + "  Item Quantity: "
                    + inventoryItem.itemQuantity
            );
        }
        Debug.Log(
            "********************************************************************************"
        );
    }
}

// List<InventoryItem>[] inventoryLists = new List<InventoryItem>[3]; // Initialize the array with a size of 3

// List<InventoryItem> list = inventoryLists[2];

// Console.WriteLine(inventoryLists[0]);

// We declare and initialize the inventoryLists array with a size of 3 using new List<InventoryItem>[3]. This creates an array that can hold three lists of InventoryItem objects.

// Now, you can safely access inventoryLists[2] without getting the "Use of unassigned local variable" error.
