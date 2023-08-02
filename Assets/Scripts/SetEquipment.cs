using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetEquipment : MonoBehaviour
{
    public PlayerStadistics playerStadistics;
    public PlayerVisualEquipment playerEquipment;


    [Space(50)]
    public ElementPlayerScriptableObject equipmentPlayer;

    private void Start()
    {
        playerEquipment = GameObject.Find("Player").GetComponent<PlayerVisualEquipment>();
        playerStadistics = GameObject.Find("Player").GetComponent<PlayerStadistics>();
    }


    public void SetNewEquipment()
    {
        playerEquipment.SetSpritesEquipment(equipmentPlayer.equipmentType, equipmentPlayer.spritesObj);
        playerStadistics.SetNewHealth(equipmentPlayer.equipmentType, equipmentPlayer.health);
        playerStadistics.SetNewSpeed(equipmentPlayer.equipmentType, equipmentPlayer.speed);
        this.gameObject.SetActive(false);
    }

    public void SellItem()
    {
        playerStadistics.money += equipmentPlayer.price;
        Destroy(this.gameObject);
    }
}
