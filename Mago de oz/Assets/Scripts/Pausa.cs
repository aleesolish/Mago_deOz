using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour {
    [SerializeField] 
    private GameObject panel;


	// Use this for initialization
	void Start () {

        panel.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)){
            Debug.Log("presionaste Esc");
            if (panel.activeInHierarchy == false){
                PauseGame();
            }

            if (panel.activeInHierarchy == true)
            {
                ContinueGame();
            }
        }
		
	}


    public void PauseGame(){
        Debug.Log("Pausa");
        Time.timeScale = 0;
        panel.SetActive(true);
    }

    public void ContinueGame(){
        Time.timeScale = 1;
        panel.SetActive(false);
    }
}

