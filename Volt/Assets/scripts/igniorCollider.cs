using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class igniorCollider : MonoBehaviour {

	public GameObject[] objects;

	void Start () {
		foreach(GameObject obj in objects)		
		{
			Physics2D.IgnoreCollision(obj.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
		}
	}
}
