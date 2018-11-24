using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Golpe : MonoBehaviour {
    public GameObject punch;
    private float waitTime = 0.6f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            StartCoroutine("Punch"); 
        }
	}

    IEnumerator Punch(){
        punch.gameObject.SetActive(true);

        yield return new WaitForSeconds(waitTime);
        punch.gameObject.SetActive(false);

    }
}
