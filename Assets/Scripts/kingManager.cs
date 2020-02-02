using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Globals;

public class kingManager : MonoBehaviour
{
    private int price = 9;
    public GameObject prefab;
    private void OnMouseDown()
    {
        if (global.gold >= price && global.level >= 7)
        {
            global.gold -= price;
            Instantiate(prefab, new Vector3(1.51f, -4.15f, -0.01f), Quaternion.identity);
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
