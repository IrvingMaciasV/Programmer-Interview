using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStadistics : MonoBehaviour
{
    [SerializeField] int originalHealth;
    [SerializeField] int currentHealth;
    private int healthHead;
    private int healthTorso;
    private int healthLegs;

    [SerializeField] int originalSpeed;
    [SerializeField] int currentSpeed;
    private int speedHead;
    private int speedTorso;
    private int speedLegs;

    public void SetNewHealth(EquipmentType equipmentType, int newComplementHealth)
    {
        switch (equipmentType)
        {
            case EquipmentType.Head: 
                healthHead = newComplementHealth; 
            break;
            case EquipmentType.Torso: 
                healthTorso = newComplementHealth;
            break;
            case EquipmentType.Legs: 
                healthLegs = newComplementHealth; 
            break;
        }

        currentHealth = originalHealth + healthHead + healthLegs + healthTorso;
    }

    public void SetNewSpeed(EquipmentType equipmentType, int newComplementSpeed)
    {
        switch (equipmentType)
        {
            case EquipmentType.Head:
                healthHead = newComplementSpeed;
                break;
            case EquipmentType.Torso:
                healthTorso = newComplementSpeed;
                break;
            case EquipmentType.Legs:
                healthLegs = newComplementSpeed;
                break;
        }

        currentHealth = originalSpeed + speedHead + speedLegs + speedTorso;
    }
}
