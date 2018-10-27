using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door3 : MonoBehaviour {

    Animator myAn;
    public bool IsOpen;
    Collider2D myCol;

	// Use this for initialization
	void Start () {
        myAn = GetComponent<Animator>();
        myCol = GetComponent<Collider2D>();
	}


 
    public void Open()
    {
        if (!IsOpen)
            SetState(true);
    }

    public void Close()
    {
        if (IsOpen)
            SetState(false);
    }

    public void Toggle()
    {
        if (IsOpen)
            Close();
        else
            Open();
    }

    void SetState(bool open)
    {
        IsOpen = open;
        myAn.SetBool("Open", open);
        myCol.isTrigger = open;
    }
}
