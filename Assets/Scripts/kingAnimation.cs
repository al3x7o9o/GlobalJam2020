using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Globals;

public class kingAnimation : MonoBehaviour
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

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Enemy(Clone)")
        {
            life--;
            clear = true;
            anim.Play("King");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Enemy(Clone)")
        {

            anim.Play("KingAttack");
            clear = false;
        }
    }
    public float Timer = 2;

    // Update is called once per frame
    void Update()
    {
        if (life <= 0)
        {
            Destroy(gameObject);
        }
        //if (dead)
        //{
        //    Timer -= Time.deltaTime;
        //}
        //if (Timer <= 0 && dead)
        //{
        //    Destroy(gameObject);
        //}
        if (global.status != 0)
        {
            Destroy(gameObject);
        }
        if (transform.position.x >= 60.1f)
        {
            if (global.progression < 100)
            {
                global.progression += 9;
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
