using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    [Space(50)]
    [SerializeField] int money;
    [SerializeField] Text moneyText;

    private void Start()
    {
        currentHealth = originalHealth;
        currentSpeed = originalSpeed;
        moneyText.text = money.ToString();
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

    public void ChangeMoney(int newCount)
    {
        money += newCount;
        moneyText.text = money.ToString();
    }
    
    public int GetMoney()
    {
        return money;
    }
}
