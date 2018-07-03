using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rad : MonoBehaviour {

	// Use this for initialization

	public GameObject radio;
	private bool active = false;

	void Start() {
		radio.SetActive(false);
	}

	public void Use () {
		active = !active;
		if (active == true)
			radio.SetActive(true);
		else
			radio.SetActive(false);
	}
}
