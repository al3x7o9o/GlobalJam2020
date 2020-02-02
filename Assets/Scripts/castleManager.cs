using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Globals;

public class castleManager : MonoBehaviour
{
    public GameObject a;
    public GameObject b;

    List<Sprite> Castles = new List<Sprite>();
    public GameObject knight;
    public GameObject spearman;
    public GameObject horse;
    public GameObject archer;
    public GameObject elf;
    public GameObject wizzard;
    public GameObject fairy;
    public GameObject troll;
    public GameObject king;
    public GameObject dragon;
    public Sprite Castle1;
    public Sprite Castle2;
    public Sprite Castle3;
    public Sprite Castle4;
    public Sprite Castle5;
    public Sprite Castle6;
    public Sprite Castle7;
    public Sprite Castle8;
    public Sprite Castle9;
    public Sprite Castle10;
    public Sprite Castle11;
    public Sprite Castle12;
    public Sprite Castle13;
    public Sprite Castle14;
    private int count = 0;


    // Start is called before the first frame update
    void Start()
    {
        Castles.Add(Castle1);
        Castles.Add(Castle2);
        Castles.Add(Castle3);
        Castles.Add(Castle4);
        Castles.Add(Castle5);
        Castles.Add(Castle6);
        Castles.Add(Castle7);
        Castles.Add(Castle8);
        Castles.Add(Castle9);
        Castles.Add(Castle10);
        Castles.Add(Castle11);
        Castles.Add(Castle12);
        Castles.Add(Castle13);
        Castles.Add(Castle14);
    }

    private void OnMouseDown()
    {
        if (global.upgradable)
        {
            global.upgradable = false;
            global.upgraded = true;
            count++;
            if (count != 14)
            {
                global.hp += 12;
                global.level++;
                if (global.level == 1)
                {
                    Vector3 tmp = new Vector3(knight.transform.position.x, knight.transform.position.y, -0.1f);
                    knight.transform.position = tmp;
                }
                if (global.level == 2)
                {
                    Vector3 tmp1 = new Vector3(spearman.transform.position.x, spearman.transform.position.y, -0.1f);
                    spearman.transform.position = tmp1;
                }
                if (global.level == 3)
                {
                    Vector3 tmp2 = new Vector3(horse.transform.position.x, horse.transform.position.y, -0.1f) ;
                    horse.transform.position = tmp2;
                }
                if (global.level == 4)
                {
                    Vector3 tmp3 = new Vector3(archer.transform.position.x, archer.transform.position.y, -0.1f);
                    archer.transform.position = tmp3;
                }
                if (global.level == 5)
                {
                    Vector3 tmp4 = new Vector3(elf.transform.position.x, elf.transform.position.y, -0.1f);
                    elf.transform.position = tmp4;
                    tmp4 = new Vector3(wizzard.transform.position.x, wizzard.transform.position.y, -0.1f);
                    wizzard.transform.position = tmp4;
                }
                if (global.level == 6)
                {
                    Vector3 tmp5 = new Vector3(fairy.transform.position.x, fairy.transform.position.y, -0.1f);
                    fairy.transform.position = tmp5;
                    tmp5 = new Vector3(troll.transform.position.x, troll.transform.position.y, -0.1f);
                    troll.transform.position = tmp5;
                }
                if (global.level == 6)
                {

                    Vector3 tmp6 = new Vector3(king.transform.position.x, king.transform.position.y, -0.1f);
                    king.transform.position = tmp6;
                    tmp6 = new Vector3(dragon.transform.position.x, dragon.transform.position.y, -0.1f);
                    dragon.transform.position = tmp6;
                }
                if (global.level == 7)
                {
                    Destroy(a);
                    Destroy(b);
                    global.status = 1;
                }

                GetComponent<SpriteRenderer>().sprite = Castles[count];
            }
            if (count == 13)
            {
                global.hp = 100;
                global.maxed = true;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
            if (global.status == -1)
            {
                Destroy(gameObject);
            }
        //Debug.Log(count);
        if (global.toChange)
        {
            global.toChange = false;
            count++;
            if (count != 13)
            {
                GetComponent<SpriteRenderer>().sprite = Castles[count];
            }
        }
    }
}
