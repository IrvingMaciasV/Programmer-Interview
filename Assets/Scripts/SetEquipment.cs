using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetEquipment : MonoBehaviour
{
    public bool SetItem;
    public bool canInteract = true;
    public PlayerStadistics playerStadistics;
    public PlayerVisualEquipment playerEquipment;
    public PlayerInventory playerInventory;
    public int it;

    [Space(50)]
    public ElementPlayerScriptableObject equipmentPlayer;

    private void Start()
    {
        playerInventory = GameObject.Find("Player").GetComponent<PlayerInventory>();

        if (!canInteract)
        {
            GetComponent<Button>().interactable = false;
        }
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
        //playerInventory.SetAllInteractable(equipmentPlayer.equipmentType);
        playerEquipment.SetSpritesEquipment(equipmentPlayer.equipmentType, equipmentPlayer.spritesObj);
        playerStadistics.SetNewHealth(equipmentPlayer.equipmentType, equipmentPlayer.health);
        playerStadistics.SetNewSpeed(equipmentPlayer.equipmentType, equipmentPlayer.speed);
        //BoolInteract(false, equipmentPlayer.equipmentType);
        //this.gameObject.SetActive(false);
    }

    public void BoolInteract(bool b, EquipmentType type)
    {
        if (type == equipmentPlayer.equipmentType)
        {
            canInteract = b;
            this.gameObject.GetComponent<Button>().interactable = b;
        }
    }

    public void FindReferences()
    {
        if (playerEquipment == null)
            playerEquipment = GameObject.Find("Player").GetComponent<PlayerVisualEquipment>();
        if (playerStadistics == null)
            playerStadistics = GameObject.Find("Player").GetComponent<PlayerStadistics>();
        if(playerInventory == null)
            playerInventory = GameObject.Find("Player").GetComponent<PlayerInventory>();

    }

    public void SellItem()
    {
        playerInventory = GameObject.Find("Player").GetComponent<PlayerInventory>();
        
        playerInventory.DeleteItem(this);
    }

}
