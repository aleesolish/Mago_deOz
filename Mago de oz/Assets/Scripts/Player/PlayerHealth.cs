using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    Animator anim;
    public Slider HealthSlider;

    public static float maxHealth = 100f;
    public float currentHealth;
    public bool Damage;
    public GameMaster LevelManager;
    public float TimeAfterHurt = 0.1f;
    public GameObject inicio;


    public Player_Moving Player_Moving;
    public PausedMenu Paused_Menu;
    void Start()
    {
        currentHealth = maxHealth;
        anim = GetComponent<Animator>();
        HealthSlider.value = maxHealth;
        currentHealth = HealthSlider.value;



        LevelManager = FindObjectOfType<GameMaster>();



    }




    void OnCollisionEnter2D(Collision2D collision)
    {
        RatMove RatAraña = collision.collider.GetComponent<RatMove>();
        Engrane Engranes = collision.collider.GetComponent<Engrane>();
        Flamas FireDamage = collision.collider.GetComponent<Flamas>();




        if (Engranes != null)
        {
            HealthSlider.value -= 5 ;
            currentHealth = HealthSlider.value;
            HurtTimer(TimeAfterHurt); // Activa el Trigger en el Animator
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-25, 1200)); //Resetea la velocidad del personaje para que no avance mientras ataca
            Hurt();
        }

        if (FireDamage != null)
        {
            HealthSlider.value -= 5;
            currentHealth = HealthSlider.value;
            HurtTimer(TimeAfterHurt); // Activa el Trigger en el Animator
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-25, 1200)); //Resetea la velocidad del personaje para que no avance mientras ataca
            Hurt();
        }

        if (collision.gameObject.CompareTag("proyecty"))
        {
            HealthSlider.value -= .5f;
            currentHealth = HealthSlider.value;
            HurtTimer(TimeAfterHurt); // Activa el Trigger en el Animator
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-25, 1200)); //Resetea la velocidad del personaje para que no avance mientras ataca
            Hurt();
        }



    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        RatMove RatAraña = gameObject.GetComponent<RatMove>();
        if (gameObject.tag == "Deadly"){

            HealthSlider.value -= 35f;
            currentHealth = HealthSlider.value;
            HurtTimer(TimeAfterHurt); // Activa el Trigger en el Animator
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-25, 1200)); //Resetea la velocidad del personaje para que no avance mientras ataca
            Hurt();
            }


       


    }
    void Hurt(){
       

        if(currentHealth <= 0 )
        {

            Player_Moving.TriggerHurt(TimeAfterHurt);
            Paused_Menu.DeathRestart();

        }
    }

    public void HurtTimer(float HurtTime)
    {
        StartCoroutine(HurtAnim(HurtTime));
    }

    IEnumerator HurtAnim(float HurtTime)
    {
        anim.SetTrigger("Hurt");
        yield return new WaitForSeconds(HurtTime);

        anim.ResetTrigger("Hurt");
    }

	private void Update()
	{
        if (currentHealth<= 0 ){
            gameObject.transform.position = inicio.transform.position;
            HealthSlider.value = 100f;
            currentHealth = HealthSlider.value;
        }
	}

}


