using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winRadio : MonoBehaviour {


	public GameObject txt1;
	public GameObject txt2;
	private bool ok = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ok == false && txt1.transform.localPosition.x == 0 && txt1.transform.localPosition.y == 0
		&& txt2.transform.localPosition.x == 0 && txt2.transform.localPosition.y == 0)
			{
				ok = true;
				txt1.SetActive(false);
				txt2.SetActive(false);
				GetComponent<Animator>().SetBool("win", true);
				GetComponent<AudioSource>().Play();
			}
	}
}
