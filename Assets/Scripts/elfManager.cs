using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Globals;

public class elfManager : MonoBehaviour
{
    private int price = 5;
    public GameObject prefab;
    private void OnMouseDown()
    {
        if (global.gold >= price && global.level >= 5)
        {
            global.gold -= price;
            Instantiate(prefab, new Vector3(1.48f, -5.08f, -0.01f), Quaternion.identity);
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
