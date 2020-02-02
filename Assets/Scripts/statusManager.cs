using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Globals;

public class statusManager : MonoBehaviour
{

    public GameObject prefab;
    public GameObject win;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (global.status == -1)
        {
            Quaternion tmp = new Quaternion(0, 0, 0, 0);
            Instantiate(prefab, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), tmp);
            global.status = 100;
        }
        if (global.status == 1)
        {
            Quaternion tmp = new Quaternion(0, 0, 0, 0);
            Instantiate(win, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), tmp);
            global.status = 100;
        }
    }
}
