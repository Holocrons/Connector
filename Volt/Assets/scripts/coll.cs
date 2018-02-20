using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coll : MonoBehaviour {

	public GameObject seche;
	private bool mdr = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		if (mdr == true && other.gameObject.name == "vacuum")
		{
			seche.GetComponent<Animator>().enabled = true;	
			mdr = false;
		}
	}
}
