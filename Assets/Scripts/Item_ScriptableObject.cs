using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class Item_ScriptableObject : ScriptableObject
{
    //Creamos el enum
    public enum ItemType { Sword, Shield, Magic, Potion }


    //Variables del item
    public string Name;
    public int Price;
    public Sprite Sprite;
    public ItemType Type;
}
