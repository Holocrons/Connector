using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour {

	public GameObject socket;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "salt")
			GetComponent<Animator>().SetBool("fall", true);
		if (other.name == "vacuumWet")
		{
			socket.tag = "link";
		}
	}
}
