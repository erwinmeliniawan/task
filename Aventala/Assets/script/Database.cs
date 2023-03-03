using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
    public static List<Item> itemList = new List<Item>(); 

    void Awake ()
    {
        itemList.Add(new Item(0, "None", "None"));
        itemList.Add(new Item(1, "None", "None"));
        itemList.Add(new Item(2, "None", "None"));
        itemList.Add(new Item(3, "None", "None"));
        itemList.Add(new Item(4, "None", "None"));
        itemList.Add(new Item(5, "None", "None"));
    }


}
