using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetEquipment : MonoBehaviour
{
    PlayerStadistics playerStadistics;
    PlayerVisualEquipment playerEquipment;

    public void SetNewEquipment(ElementPlayerScriptableObject equipmentPlayer)
    {
        playerEquipment.SetSpritesEquipment(equipmentPlayer.equipmentType, equipmentPlayer.spritesObj);
        playerStadistics.SetNewHealth(equipmentPlayer.equipmentType, equipmentPlayer.health);
        playerStadistics.SetNewSpeed(equipmentPlayer.equipmentType, equipmentPlayer.speed);
    }
}
