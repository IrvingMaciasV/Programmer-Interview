using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EquipmentType
{
    Head,
    Torso,
    Legs
}

[CreateAssetMenu(fileName = "DataPlayer", menuName = "ScriptableObjects/EquipmentPlayer", order = 1)]
public class ElementPlayerScriptableObject : ScriptableObject
{ 
    public EquipmentType equipmentType;
    public List<Sprite> spritesObj;
    public int price;

    [Header("Stadistics")]
    public int speed;
    public int health;
}
