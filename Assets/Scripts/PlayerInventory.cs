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


    public void AddItem(SetEquipment go)
    {
        if (player.GetMoney() >= go.equipmentPlayer.price)
        {
            inventory.Add(go);
            player.ChangeMoney( -go.equipmentPlayer.price);
        }
    }

    public void DeleteItem(SetEquipment go)
    {
        player.ChangeMoney(go.equipmentPlayer.price);
        inventory.Remove(go);
        int itGo = go.it;
        
        Destroy(go.gameObject);

        for (int i = 0; i < inventory.Count; i++)
        {
            if (go.it == inventory[i].it)
            {
                inventory.RemoveAt(i);
                inventoryUI.RemoveAt(i);
                RestartIt();
                return;
            }
        }
    }

    public void ShowItemsSet(GameObject parent)
    {
        DestroyElements();
        inventoryUI = new List<SetEquipment>();
        for (int i = 0; i < inventory.Count; i++)
        {
            SetEquipment item;
            item = Instantiate(inventory[i]);
            item.SetItem = true;
            item.it = i;
            item.transform.SetParent(parent.transform);
            item.transform.localScale = Vector3.one;
            inventoryUI.Add(item);
        }
    }
    
    public void ShowItemsSell(GameObject parent)
    {
        DestroyElements();
        inventoryUI = new List<SetEquipment>();
        for (int i=0; i<inventory.Count;i++)
        {
            SetEquipment item;
            item = Instantiate(inventory[i]);
            item.SetItem = false;
            item.it=i;
            item.transform.SetParent(parent.transform);
            item.transform.localScale = Vector3.one;
            inventoryUI.Add(item);
        }
    }

    private void DestroyElements()
    {
        foreach (var item in inventoryUI)
        {
            Destroy(item.gameObject);
        }

        inventoryUI.Clear();
    }

    private void RestartIt()
    {
        for(int i = 0; i < inventory.Count; i++)
        {
            inventory[i].it = i;
            inventoryUI[i].it = i;
        }
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
