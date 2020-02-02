using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Globals;

public class horseManager : MonoBehaviour
{
    private int price = 3;
    public GameObject prefab;
    private void OnMouseDown()
    {
        if (global.gold >= price && global.level >= 3)
        {
            global.gold -= price;
            Instantiate(prefab, new Vector3(3.6f, -3.98f, -0.01f), Quaternion.identity);
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
