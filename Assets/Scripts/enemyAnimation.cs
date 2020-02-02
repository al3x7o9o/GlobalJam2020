using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Globals;

public class enemyAnimation : MonoBehaviour
{
    private bool dead = false;
    private bool clear = true;
    public float speed;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name != "portal" && collision.name != "Enemy(Clone)" && collision.name != "Castle")
        {
            global.gold++;
            dead = true;
            anim.Play("enemyAttack");
            clear = false;
        }
        if (collision.name == "Castle")
        {
            global.gold--;
            dead = true;
            anim.Play("enemyAttack");
            clear = false;
        }
    }
    public float Timer = 2;

    // Update is called once per frame
    void Update()
    {
        if (global.status != 0)
        {
            Destroy(gameObject);
        }
        if (dead)
        {
            Timer -= Time.deltaTime;
        }
        if (Timer <= 0 && dead)
        {
            Destroy(gameObject);
        }
        if (clear)
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
    }
}
