using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Globals;
public class dragonManager : MonoBehaviour
{
    private int price = 10;
    public GameObject prefab;
    private void OnMouseDown()
    {
        if (global.gold >= price && global.level >= 6)
        {
            global.gold -= price;
            Instantiate(prefab, new Vector3(1.25f, -2.5f, -0.01f), Quaternion.identity);
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
