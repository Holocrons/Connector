using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveNotes : MonoBehaviour {

	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		//GameObject.Destroy(gameObject, 5);
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = new Vector2(0, -1) * Time.deltaTime * 5;
		rb.MovePosition(transform.position + pos);
		
	}
}
