using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Globals;

public class trollManager : MonoBehaviour
{
    private int price = 8;
    public GameObject prefab;
    private void OnMouseDown()
    {
        if (global.gold >= price && global.level >= 6)
        {
            global.gold -= price;
            Instantiate(prefab, new Vector3(1.58f, -4.87f, -0.01f), Quaternion.identity);
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
