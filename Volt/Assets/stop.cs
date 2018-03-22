using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop : MonoBehaviour {

	public GameObject socket;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (socket.tag == "link")
		{
			GetComponent<autoVacuum>().enabled = false;
			GetComponent<vac>().enabled = false;
			GetComponentsInChildren<Animator>()[2].SetBool("water", true);
		}
	}
}
