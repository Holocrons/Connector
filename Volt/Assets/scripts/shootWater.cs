using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootWater : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D other)
	{
		Destroy(this.gameObject, 0.2f);
	}
}
