using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemStore : MonoBehaviour
{
    private PlayerInventory inventory;
    public SetEquipment prefabItem;


    private void Start()
    {
        inventory = GameObject.Find("Player").GetComponent<PlayerInventory>();
    }

    public void BuyItem()
    {
        inventory.AddItem(prefabItem);
        //Destroy(this.gameObject);
    }

    public void SellItem()
    {
        prefabItem.SellItem();
    }
}
