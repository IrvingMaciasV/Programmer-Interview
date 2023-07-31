using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVisualEquipment : MonoBehaviour
{
    public List<SpriteRenderer> spritesHead;
    public List<SpriteRenderer> spritesTorso;
    public List<SpriteRenderer> spritesLegs;

    public void SetSpritesEquipment(EquipmentType type, List<Sprite> newsprites)
    {
        switch (type)
        {
            case EquipmentType.Head:
                SetSpritesHead(newsprites);
                break;
            case EquipmentType.Torso:
                SetSpritesTorso(newsprites);
                break;
            case EquipmentType.Legs:
                SetSpritesLegs(newsprites);
                break;
        }
    }

    private void SetSpritesHead(List<Sprite> newSprites)
    {
        for(int i = 0; i < spritesHead.Count; i++)
        {
            spritesHead[i].sprite = newSprites[i];
        }
    }

    private void SetSpritesTorso(List<Sprite> newSprites)
    {
        for (int i = 0; i < spritesTorso.Count; i++)
        {
            spritesTorso[i].sprite = newSprites[i];
        }
    }
    
    private void SetSpritesLegs(List<Sprite> newSprites)
    {
        for (int i = 0; i < spritesLegs.Count; i++)
        {
            spritesLegs[i].sprite = newSprites[i];
        }
    }
}
