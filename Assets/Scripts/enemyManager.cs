using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Globals;

public class enemyManager : MonoBehaviour
{
    private int count = 0;
    public GameObject prefab;
    //private void OnMouseDown()
    //{
    //    Quaternion tmp = new Quaternion(0, 180, 0, 0);
    //    Instantiate(prefab, new Vector3(60f, -5f, -0.01f), tmp);
    //}
    public float Timer = 4;

    void Update()
    {
        if (global.status != 0)
        {
            Destroy(gameObject);
        }
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            count++;
            Quaternion tmp = new Quaternion(0, 180, 0, 0);
            Instantiate(prefab, new Vector3(60f, -5f, -0.01f), tmp);
            Timer = 6;

        }
        if (count  == 6)
        {
            count = 0;
            Timer = 15;
        }

    }
}