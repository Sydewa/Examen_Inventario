using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Item_ScriptableObject[] Items;
    public Text[] ItemTexts;
    public Image[] ItemSprites;

    public void AddItem(Item_ScriptableObject item)
    {
        for(int i = 0; i < Items.Length; i++)
        {
            if(Items[i] == null)
            {
                Items[i] = item;
                ItemTexts[i].text = item.Name + ": " + item.Price + "€";
                ItemSprites[i].sprite = item.Sprite;
                return;
            }
        }
    }
}
