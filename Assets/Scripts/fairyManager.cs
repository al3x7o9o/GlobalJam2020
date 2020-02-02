using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Globals;

public class fairyManager : MonoBehaviour
{
    private int price = 7;
    public GameObject prefab;
    private void OnMouseDown()
    {
        if (global.gold >= price && global.level >= 6)
        {
            global.gold -= price;
            Instantiate(prefab, new Vector3(1.44f, -3.3f, -0.01f), Quaternion.identity);
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
