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

    public int GetHealth()
    {
        return currentHealth;
    }
    
    public int GetSpeed()
    {
        return currentSpeed;
    }
}
