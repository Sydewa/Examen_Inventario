using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickeable_Item : MonoBehaviour
{
    public Item_ScriptableObject Item;
    SpriteRenderer s_Renderer;
    void Start()
    {
        s_Renderer = GetComponent<SpriteRenderer>();
        s_Renderer.sprite = Item.Sprite;
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.name == "Player")
        {
            InventoryManager.Instance.AddItem_Manager(Item);
            Destroy(this.gameObject);
        }
    }
}
