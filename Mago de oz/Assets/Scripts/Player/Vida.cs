using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour {
    private int value = 30;
    public PlayerHealth player;
    public Slider HealthSlider;

	private void OnTriggerEnter2D(Collider2D other)
	{
        if (other.CompareTag("Player")) {
            player.currentHealth += value;
            HealthSlider.value = player.currentHealth;
            Destroy(gameObject);
        }

            
	}

	private void Start()
	{
        HealthSlider = player.HealthSlider;
	}

}
