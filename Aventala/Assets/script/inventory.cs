using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public List<Item> yourInventory = new List<Item>();
    public int slotsNumber;

    public GameObject x;
    public int n; 

    // Start is called before the first frame update
    void Start()
    {
        yourInventory[0] = Database.itemList[2];
        yourInventory[3] = Database.itemList[2]; 
    }

    // Update is called once per frame
    void Update()
    {
        if(pickup.y != null)
        {
            x = pickup.y;
            n = x.GetComponent<ThisItem>().thisId; 
        }
        else
        {
            x = null; 
        }

        if (pickup.pick == true)
        {
            for(int i = 0; i<slotsNumber; i++)
            {
                if(yourInventory[i].id == 0 && pickup.pick == true)
                {
                    yourInventory[i] = Database.itemList[n];
                    pickup.pick = false; 
                }
            }
            pickup.pick = false; 
        }
    }
}
