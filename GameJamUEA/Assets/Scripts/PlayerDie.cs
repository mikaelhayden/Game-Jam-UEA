using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerDie : MonoBehaviour
{
    public FireArea area;
    public int health;
    public bool isDead;
    private Animator anim;
 

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "fire")
        {
            dano();
        }
    }

    public void dano() //Função para fazer o Player Morrer
    {
        health -= 1;
        area.Velocidade = 0.0f;

        if (health <= 0)
        {
            //player morre
            isDead = true;
            anim.SetTrigger("die");
            //over.gameOver();
        }
    }


}
