using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;

    public Inventory SwordInventory;
    public Inventory ShieldInventory;

    void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
        DontDestroyOnLoad(Instance);
    }

    public void AddItem_Manager(Item_ScriptableObject Item)
    {
        switch(Item.Type)
        {
            default:
            break;

            case Item_ScriptableObject.ItemType.Sword:
                SwordInventory.AddItem(Item);
            break;

            case Item_ScriptableObject.ItemType.Shield:
                ShieldInventory.AddItem(Item);
            break;
        }
    }
}
