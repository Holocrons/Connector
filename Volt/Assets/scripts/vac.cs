﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vac : MonoBehaviour {

	private bool right = true;
	public static bool ok = false;
	private Rigidbody2D rb;
	public GameObject player;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (ok == true)
		{
			player.transform.position = transform.position;
			if (Input.GetKey(KeyCode.D))
			{
				rb.velocity = new Vector2(5f, 0);
				right = true;
			}
			else if (Input.GetKey(KeyCode.Q))
			{
				rb.velocity = new Vector2(-5f, 0);
				right = false;
			}
			else
				rb.velocity = new Vector2(0, 0);
			if (right == true && transform.localScale.x < 0 || right == false && transform.localScale.x > 0)
				flip();
			}
	}
	
	void flip()
	{
		transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
	}
}
