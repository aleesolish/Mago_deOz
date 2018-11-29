using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RatMove : MonoBehaviour
{
    public float moveSpeed;
    bool moveRight;
    public Transform Weakness;
    public Collision2D[] contacts;
    public bool colliding;
    Animator anim;
    float reverse = 1.0f;
    public AudioClip deadRat;
    public AudioSource audio;

    public Rigidbody2D rb;

    public Time time;
    private float sec = 0.0f;
    private PlayerHealth player;
    private Slider slider;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        moveRight = true;
        player = FindObjectOfType<PlayerHealth>();
        slider = player.HealthSlider;
        audio = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        sec += Time.deltaTime;

        transform.position = new Vector3(transform.position.x + (reverse * moveSpeed) * Time.deltaTime, transform.position.y);
        if (sec > 3.0f)
        {
            Sniff();
            sec = 0;
            audio.Play();
        }
        if(transform.position.x<-160){
            Destroy(gameObject);
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
        audio.clip = deadRat;
        audio.Play();
        Destroy(this.gameObject, .8f);
        gameObject.tag = "Neutralized";
        moveSpeed = 0;
    }

    private void OnTriggerEnter2D(Collider2D other)
	{
        if(other.CompareTag("Player")){
            player.currentHealth -= 5f;
            slider.value = player.currentHealth;
        }
	}


}
