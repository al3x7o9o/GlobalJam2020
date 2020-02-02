using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Globals;

public class spearmanManager : MonoBehaviour
{
    private int price = 2;
    public GameObject prefab;
    private void OnMouseDown()
    {
        if (global.gold >= price && global.level >= 2)
        {
            global.gold -= price;
            Instantiate(prefab, new Vector3(1.59f, -4.91f, -0.01f), Quaternion.identity);
        }
    }
    void update()
    {
        if (global.status != 0)
        {
            Destroy(gameObject);
        }
    }
}
