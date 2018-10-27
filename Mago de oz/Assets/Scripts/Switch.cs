/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {


    [SerializeField]
    GameObject switchOFF;

    [SerializeField]
    GameObject switchON;

    public Doortrigger[] doorTrig;
    

    public bool isON = false;
    public bool sticks;



    // Use this for initialization
    void Start () {

        gameObject.GetComponent<SpriteRenderer>().sprite = switchOFF.GetComponent<SpriteRenderer>().sprite;


    }

    void SetState(bool on)
    {
        myan.Setbool("");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay2D()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = switchON.GetComponent<SpriteRenderer>().sprite;

        isON = true;
       
        foreach(Doortrigger trigger in doorTrig)
        {
            trigger.Toggle(true);
        }
    }

     





}
*/