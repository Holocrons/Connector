using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoVacuum : MonoBehaviour {

	private Rigidbody2D rb;
	private int x = 1;
	private bool right = true;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();	
		transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
	}
	
	// Update is called once per frame
	void Update () {	
		if (vac.ok == false)
		{
			transform.Translate(new Vector2(x, 0) * Time.deltaTime);
			if (transform.position.x < -2.5f )
			{
				right = true;
				x *= -1;
			}
			else if (transform.position.x > 2.5f)
			{
				right = false;
				x *= -1;
			}
			if (right == true && transform.localScale.x < 0 || right == false && transform.localScale.x > 0)
				flip();
		}
	}

	void flip()
	{
		transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
	}
}
