using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerdeMono : MonoBehaviour {

	private void OnCollisionEnter2D(Collision2D collision)
	{
        Destroy(gameObject,3f);
	}
}
