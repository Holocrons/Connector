using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyNotes : MonoBehaviour {

	public string _tag;
	public string keys;

	void OnTriggerStay2D(Collider2D other)
	{
		if (Input.GetKeyDown(keys))
			Destroy(other.gameObject);
	}
}
