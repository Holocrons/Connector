using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toaster : MonoBehaviour {

	private bool canDo = true;
	public GameObject bread;
	private Rigidbody2D rb;

	void Start () {	
		rb = bread.GetComponent<Rigidbody2D>();
	}
	
	public void Use () {
		rb.bodyType = RigidbodyType2D.Dynamic;
		rb.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
	}
}
