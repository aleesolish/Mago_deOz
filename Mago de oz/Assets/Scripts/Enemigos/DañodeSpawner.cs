using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DañodeSpawner : MonoBehaviour
{
    [SerializeField]
    private float dano = .5f;
    private PlayerHealth player;
    private Slider slider;

    private void Start()
    {
        player = FindObjectOfType<PlayerHealth>();
        slider = player.HealthSlider;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.currentHealth -= dano;
            slider.value = player.currentHealth;

        }

    }
}