using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    List<SetEquipment> inventory = new List<SetEquipment>();
    List<GameObject> inventoryUI = new List<GameObject>();
    PlayerStadistics player;
    public GameObject parent;

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerStadistics>();
    }

    public void SetItems()
    {
        DestroyElements();
        int id = 0;
        foreach (SetEquipment item in inventory)
        {
            GameObject i;
            i = Instantiate(item.gameObject);
            i.transform.SetParent(parent.transform);
            i.transform.localScale = Vector3.one;
            item.SetID(id);
            id++;
            inventoryUI.Add(i);
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
        foreach(SetEquipment i in inventory)
        {
            if (i == go)
            {
                Debug.Log("Find");
                player.money += i.equipmentPlayer.price;
                inventory.Remove(i);
                Destroy(i.gameObject);
                return;
            }
        }
    }

    public void ShowItemsSet(GameObject parent)
    {
        DestroyElements();
        foreach(SetEquipment item in inventory)
        {
            item.SetItem = true;
            GameObject i;
            i = Instantiate(item.gameObject);
            i.transform.SetParent(parent.transform);
            i.transform.localScale = Vector3.one;
            inventoryUI.Add(i);
        }
    }
    
    public void ShowItemsSell(GameObject parent)
    {
        DestroyElements();
        foreach(SetEquipment item in inventory)
        {
            item.SetItem = false;
            GameObject i;
            i = Instantiate(item.gameObject);
            i.transform.SetParent(parent.transform);
            i.transform.localScale = Vector3.one;
            inventoryUI.Add(i);
        }
    }

    private void DestroyElements()
    {
        foreach(GameObject i in inventoryUI)
        {
            Destroy(i);
        }
    }

}
