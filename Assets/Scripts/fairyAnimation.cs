using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Globals;

public class fairyAnimation : MonoBehaviour
{
    private bool dead = false;
    public int life;
    private bool clear = true;
    Animator anim;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Enemy(Clone)")
        {

            anim.Play("fairy_attack");
            life--;
            clear = false;
        }
    }
    public float Timer = 2;
    // Update is called once per frame
    void Update()
    {
        if (life <= 0)
        {
            dead = true;
        }
        if (dead)
        {
            Timer -= Time.deltaTime;
        }
        if (Timer <= 0 && dead)
        {
            Destroy(gameObject);
        }
        if (global.status != 0)
        {
            Destroy(gameObject);
        }
        if (transform.position.x >= 60.1f)
        {
            if (global.progression < 100)
            {
                global.progression += 7;
            }
            if (global.progression >= 100)
            {
                global.progression = 100;
            }
            Destroy(gameObject);
        }
        if (clear)
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
    }
}
