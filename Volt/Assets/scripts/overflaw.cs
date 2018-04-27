using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overflaw : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "salt")
			GetComponent<Animator>().SetBool("fall", true);
	}
}
