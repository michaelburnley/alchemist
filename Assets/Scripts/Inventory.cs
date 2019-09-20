using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private int slots;
    private List<Item> items = new List<Item>();
    private InventoryType type;
    private Dictionary<string, int> quantities = new Dictionary<string, int>();

    public List<Item> Items {
        get {
            return items;
        }
    }

    public Dictionary<string, int> Quantities {
        get {
            return quantities;
        }
    }

    public Inventory(int slotAmount, InventoryType inventoryType) {
        slots = slotAmount;
        type = inventoryType;
    }
    
    public Item RemoveItem(string item_name) {
        Item usedItem = items.Find(item => item.Name == item_name);
        quantities[item_name] = quantities[item_name] - 1;
        return usedItem;
    }

    public List<Item> AddItem(Item item, int quantity) {
        items.Add(item);
        if (quantities.ContainsKey(item.Name)) {
            quantities[item.Name] = quantities[item.Name] + quantity;
        } else {
            quantities.Add(item.Name, quantity);
        }
        return items;
    }
}
