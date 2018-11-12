using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Monos : MonoBehaviour {
    private PlayerHealth player;
    private Slider slider;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerHealth>();
        slider = player.HealthSlider;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.currentHealth -= 5f;
            slider.value = player.currentHealth;
        }
    }


}
