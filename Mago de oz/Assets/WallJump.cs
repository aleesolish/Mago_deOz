using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallJump : MonoBehaviour {

    public float distance = .42f;
    Player_Moving movement;
    public float speed = 2f;
    bool walljumping;

	// Use this for initialization
	void Start () {
        movement = GetComponent<Player_Moving>();

	}
	
	// Update is called once per frame
	void Update () {

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, distance);

        if (Input.GetKeyDown(KeyCode.W) && !movement.grounded && hit.collider != null)
        {
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(speed * hit.normal.x, speed);
                //movement.topSpeed = speed * hit.normal.x;
                walljumping = true;
                transform.localScale = transform.localScale.x == 1 ? new Vector2(-1, 1) : Vector2.one;

            }
        }
        else if (hit.collider != null && walljumping)
            walljumping = false;
	}

    void OnCollisionEnter2D(Collision2D col)
    {
       
            
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * transform.localScale.x * distance);
    }
}
 