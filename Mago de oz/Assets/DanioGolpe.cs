using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DanioGolpe : MonoBehaviour {
    public Slider coraje;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Deadly"))
        {
            Destroy(collision.gameObject);
            coraje.value += 3;
        }
    }
}
