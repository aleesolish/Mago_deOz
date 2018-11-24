using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instruccion : MonoBehaviour {
    public GameObject flecha;
    public GameObject espacio;

	private void OnTriggerEnter2D(Collider2D collision)
	{
        espacio.SetActive(true);
        flecha.SetActive(true);
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
        espacio.SetActive(false);
        flecha.SetActive(false);
	}
}
