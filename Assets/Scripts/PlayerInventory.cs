using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    List<SetEquipment> inventory = new List<SetEquipment>();
    List<SetEquipment> inventoryUI = new List<SetEquipment>();
    PlayerStadistics player;
    public GameObject parent;

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerStadistics>();
    }

    public void SetItems()
    {
        DestroyElements();
        foreach (SetEquipment item in inventory)
        {
            GameObject i;
            i = Instantiate(item.gameObject);
            i.transform.SetParent(parent.transform);
            i.transform.localScale = Vector3.one;
        }
    }

    public void AddItem(SetEquipment go)
    {
        if (player.money >= go.equipmentPlayer.price)
        {
            inventory.Add(go);
            player.money -= go.equipmentPlayer.price;
        }
    }

    public void DeleteItem(SetEquipment go)
    {
        player.money += go.equipmentPlayer.price;
        inventory.Remove(go);
        Destroy(go.gameObject);
        return;
    }

    public void ShowItemsSet(GameObject parent)
    {
        DestroyElements();
        for (int i = 0; i < inventory.Count; i++)
        {
            SetEquipment item;
            item = Instantiate(inventory[i]);
            item.SetItem = true;
            item.transform.SetParent(parent.transform);
            item.transform.localScale = Vector3.one;
            inventoryUI.Add(item);
        }
    }
    
    public void ShowItemsSell(GameObject parent)
    {
        DestroyElements();
        for (int i=0; i<inventory.Count;i++)
        {
            SetEquipment item;
            item = Instantiate(inventory[i]);
            item.SetItem = false;
            item.transform.SetParent(parent.transform);
            item.transform.localScale = Vector3.one;
            inventoryUI.Add(item);
        }
    }

    private void DestroyElements()
    {
        for (int i = 0; i < inventoryUI.Count; i++)
        {
            inventory[i].canInteract = inventoryUI[i].canInteract;
            Destroy(inventoryUI[i].gameObject);
        }
        inventoryUI = new List<SetEquipment>();
    }

    //public void SetAllInteractable(EquipmentType originalType)
    //{
    //    int it = 0;
    //    foreach(SetEquipment i in inventoryUI)
    //    {
    //        i.BoolInteract(true, originalType);
    //        inventory[it].canInteract = i.canInteract;
    //        Debug.Log("UI " + i.canInteract + "  Inv " + it + ": " + inventory[it].canInteract);
    //        it++;
    //    }
    //}


}
