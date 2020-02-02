using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Globals;

public class goldManager : MonoBehaviour
{
    public GameObject man;
    public GameObject pri;

    TextMesh text;
    void Start()
    {
        text = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        if (global.gold == -1)
        {
            global.status = -1;
            Destroy(gameObject);
            Destroy(man);
            Destroy(pri);
        }
        text.text = global.gold.ToString();
    }
}
