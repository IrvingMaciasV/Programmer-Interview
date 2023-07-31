using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DataPlayer", menuName = "ScriptableObjects/EquipmentPlayer", order = 1)]
public class ElementPlayerScriptableObject : ScriptableObject
{
    public List<Sprite> spritesObj;

    //Stadistics
    public int velocity;
    public int life;
}
