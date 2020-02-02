using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Globals;

public class knightManager : MonoBehaviour
{
    private int price = 1;
    public GameObject prefab;
    private void OnMouseDown()
    {
        if (global.gold >= price && global.level >= 1)
        {
            global.gold -= price;
            Instantiate(prefab, new Vector3(1.42f, -4.76f, -0.01f), Quaternion.identity);
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
