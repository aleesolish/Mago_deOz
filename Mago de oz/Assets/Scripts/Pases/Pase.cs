using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pase : MonoBehaviour {

    public GameObject cambio;

	// Use this for initialization
	private void OnTriggerEnter2D(Collider2D other)
	{
        other.transform.position = cambio.transform.position; 
	}
}
