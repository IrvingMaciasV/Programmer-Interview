using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemStore : MonoBehaviour
{
    public GameObject prefabItem;
    public GameObject ParentCanvas;

    public void BuyItem()
    {
        GameObject item;
        item=Instantiate(prefabItem);
        item.transform.SetParent(ParentCanvas.transform);
        item.transform.localScale = Vector3.one;
        //Destroy(this.gameObject);
    }

    public void SellItem()
    {

    }
}
