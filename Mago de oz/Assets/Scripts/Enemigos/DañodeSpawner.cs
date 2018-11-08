using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañodeSpawner : MonoBehaviour {
    [SerializeField]
    private float dano = .5f;
    private PlayerHealth player;

	private void Start()
	{
        player = FindObjectOfType<PlayerHealth>();
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
        if (other.gameObject.CompareTag("Player")){
            player.currentHealth -= dano;
            Destroy(gameObject);
        }
	}




}
