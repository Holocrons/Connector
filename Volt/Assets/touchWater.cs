using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchWater : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "water")
		{
			if (gameObject.name.IndexOf("Wet") == -1)
			{
				GetComponent<Animator>().SetBool("wet", true);
				gameObject.name = gameObject.name + "Wet";
			}
		}
	}
}
