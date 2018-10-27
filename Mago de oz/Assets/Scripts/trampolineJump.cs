using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trampolineJump : MonoBehaviour {

    bool onTop;

    GameObject bouncer;
    public Vector2 velocity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnCollisionStay2D(Collision2D other)
    {
        if (onTop)
        {
            bouncer = other.gameObject;
        }
        bouncer = other.gameObject;

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        onTop = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        onTop = false;
    }

    void Jump()
    {
        bouncer.GetComponent<Rigidbody2D>().velocity = velocity;
    }
}
