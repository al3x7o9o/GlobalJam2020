using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Globals;

public class progressionManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
        if (global.status != 0)
        {
            Destroy(gameObject);
        }
   
        if (!global.maxed)
        {
            Transform bar = transform.Find("Bar");
            float pro = global.progression / 100;
            bar.localScale = new Vector3(pro, 1f);
            if (global.progression == 100 && global.upgraded && !global.upgradable)
            {
                global.progression = 1;
                global.upgradable = true;
                global.upgraded = false;
                global.toChange = true;
            }
        }
    }
}
