using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aguila : MonoBehaviour
{
    //Variables
    Animator anim;
    bool girar = true;
    SpriteRenderer aguilaRender;

    //Funciones -----------------------------------------

    private void Voltear()
    {
        voltearCaballero = !voltearCaballero;
        caballeroRender.flipX = !caballeroRender.flipX;
    }

    //-----------------------------------------------------

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        aguilaRender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
