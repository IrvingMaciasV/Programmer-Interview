using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStadistics : MonoBehaviour
{
    [SerializeField] int originalHealth;
    [SerializeField] int currentHealth;
    public int healthHead;
    public int healthTorso;
    public int healthLegs;

    [SerializeField] int originalSpeed;
    [SerializeField] int currentSpeed;
    public int speedHead;
    public int speedTorso;
    public int speedLegs;

    private void Start()
    {
        currentHealth = originalHealth;
        currentSpeed = originalSpeed;
    }

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
        Debug.Log("Sumar");

        currentHealth = originalHealth + healthHead + healthLegs + healthTorso;
    }

    public void SetNewSpeed(EquipmentType equipmentType, int newComplementSpeed)
    {
        switch (equipmentType)
        {
            case EquipmentType.Head:
                speedHead = newComplementSpeed;
                break;
            case EquipmentType.Torso:
                speedTorso = newComplementSpeed;
                break;
            case EquipmentType.Legs:
                speedTorso = newComplementSpeed;
                break;
        }
        Debug.Log("Sumar2");
        currentSpeed = originalSpeed + speedHead + speedLegs + speedTorso;
    }
}
