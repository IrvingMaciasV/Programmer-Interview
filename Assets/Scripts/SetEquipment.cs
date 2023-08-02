using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetEquipment : MonoBehaviour
{
    public bool SetItem;
    public PlayerStadistics playerStadistics;
    public PlayerVisualEquipment playerEquipment;
    public PlayerInventory playerInventory;
    private int id;

    [Space(50)]
    public ElementPlayerScriptableObject equipmentPlayer;

    private void Start()
    {
        
    }

    public void ClickBtn()
    {
        if (SetItem)
        {
            SetNewEquipment();
        }
        else
        {
            SellItem();
        }
    }

    public void SetNewEquipment()
    {
        FindReferences();
        playerEquipment.SetSpritesEquipment(equipmentPlayer.equipmentType, equipmentPlayer.spritesObj);
        playerStadistics.SetNewHealth(equipmentPlayer.equipmentType, equipmentPlayer.health);
        playerStadistics.SetNewSpeed(equipmentPlayer.equipmentType, equipmentPlayer.speed);
        //this.gameObject.SetActive(false);
    }

    public void FindReferences()
    {
        if (playerEquipment == null)
            playerEquipment = GameObject.Find("Player").GetComponent<PlayerVisualEquipment>();
        if (playerStadistics == null)
            playerStadistics = GameObject.Find("Player").GetComponent<PlayerStadistics>();
        
    }

    public void SellItem()
    {
        playerInventory = GameObject.Find("Player").GetComponent<PlayerInventory>();
        
        playerInventory.DeleteItem(id);
    }

    public void SetID(int idNew)
    {
        id = idNew;
    }
}
