using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatMove : MonoBehaviour
{
    public float moveSpeed;
    bool moveRight;
    public Transform Weakness;
    public Collision2D[] contacts;
    public bool colliding;
    Animator anim;
    float reverse = 1.0f;

    public Rigidbody2D rb;

    public Time time;
    private float sec = 0.0f;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        moveRight = true;
    }

    void Update()
    {
        sec += Time.deltaTime;

        transform.position = new Vector3(transform.position.x + (reverse * moveSpeed) * Time.deltaTime, transform.position.y);
        if (sec > 5.0f)
        {
            Sniff();
            sec = 0;
        }
    }

    private void Sniff()
    {
        anim.SetTrigger("sniff");
    }


    void Flip()
    {
        // Diciendole que apuntamos a la direccion opuesta
        moveRight = !moveRight;
        // Obtener LOCALSCALE
        Vector3 theScale = gameObject.transform.localScale;
        // Voltaer en eje X
        // Aplicar transformacion en LOCAL SCALE
        Debug.Log("Entra a escala");
        gameObject.transform.localScale = new Vector3(-1 * theScale.x, theScale.y, theScale.z);
    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.tag == "Wall")
        {
            Debug.Log(col.gameObject.tag);
            if (moveRight)
            {

                moveRight = false;
                reverse = -1.0f;
                Flip();
            }
            else
            {
                moveRight = true;
                reverse = 1.0f;
                Flip();
            }
        }

        if (col.gameObject.tag == "Player")
        {

            float height = col.contacts[0].point.y - Weakness.position.y;

            if(height > 0){
               
                Crushed();
                col.rigidbody.AddForce(new Vector2(0, 1200));
            }
        }
    }

    public void Crushed(){

        anim.SetBool("Aplastada", true);
        Destroy(this.gameObject, 1.5f);
        gameObject.tag = "Neutralized";
    }



}
/*  if (other.gameObject.CompareTag("Player"))
{
    if (moveRight)
    {
        moveRight = false;
        transform.position = new Vector3(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
    }
    else
    {
        moveRight = true;
        transform.position = new Vector3(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
    }
}
}

private void OnCollisionEnter2D(Collision2D collision)
{
if (moveRight)
{
    moveRight = false;
    this.transform.position = new Vector3(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
}
else
{
    moveRight = true;
    this.transform.position = new Vector3(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
}
}*/

