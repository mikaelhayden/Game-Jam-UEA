using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerDie : MonoBehaviour
{
    public FireArea area;
    public int health = 3;
    public bool isDead;
    private Animator anim;
    private List<RawImage> coracoes;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        RawImage[] rawImages = GetComponentsInChildren<RawImage>();
        coracoes = rawImages.ToList();
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

    public void dano() //Fun��o para fazer o Player Morrer
    {
        health -= 1;
        area.Velocidade = 0.0f;

        if (coracoes.Count != 0)
        {
            coracoes.Last<RawImage>().enabled = false;
            coracoes.Remove(coracoes.Last<RawImage>());
        }

        if (health <= 0)
        {
            //player morre
            isDead = true;
            anim.SetTrigger("die");
            //over.gameOver();
        }
    }


}
