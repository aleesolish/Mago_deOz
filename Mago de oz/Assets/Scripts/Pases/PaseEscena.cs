﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaseEscena : MonoBehaviour
{
    

    // Use this for initialization
    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("Stage1_2");
    }
}
