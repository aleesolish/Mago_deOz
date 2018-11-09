using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door2 : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {
        anim.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DoorOpens()
    {
        //anim.SetBool("OpenDoor", true);
        Debug.Log("DoorOpen");
    }

    //void CollEnable()
    //{
      //  Collider2D.enabled = true;
    //}

    //void CollDisable()
    //{
      //  Collider2D.enabled = false;
    //}

}
