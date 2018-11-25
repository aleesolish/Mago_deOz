using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trampolineJump : MonoBehaviour {

    bool onTop;

    GameObject bouncer;
    public Vector2 velocity;

    Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerStay2D(Collider2D other)
    {
        if (onTop)
        {
            anim.SetBool("isStepped", true);
            bouncer = other.gameObject;
            Debug.Log("pisando");

        }
        else
            onTop = true;

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        onTop = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        onTop = false;
        anim.SetBool("isStepped", false);

    }

    void Jump()
    {
        bouncer.GetComponent<Rigidbody2D>().velocity = velocity;

    }
}
