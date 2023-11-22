using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    public int health;
    public Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetHit(int damage)
    {
        health -= damage;
        if (health > 0)
        {
            //player ainda ta vivo
            StopCoroutine("attack");
            //anim.SetInteger("transition", 3);
           // hiting = true;
            StartCoroutine("RecoveryFromHit");
        }

        if (health <= 0)
        {
            //player morre
            //isDead = true;
            //anim.SetTrigger("die");
            //over.gameOver();
        }
    }
}
