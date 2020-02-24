using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aguila : MonoBehaviour
{
    //Variables
    Animator anim;
    bool girar = true;
    SpriteRenderer aguilaRender;
    public float vel = 3f;
    float movement = 1f;

    //Funciones -----------------------------------------

    private void Voltear()
    {
        girar = !girar;
        aguilaRender.flipX = !aguilaRender.flipX;
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
        transform.Translate(new Vector2(Time.deltaTime * vel * movement, 0));
    }
}
