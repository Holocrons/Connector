using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoVacuum : MonoBehaviour {

	private Rigidbody2D rb;
	private int x = 1;
	public float minx = -2.5f;
	public float maxx = 2.5f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();	
	}
	
	// Update is called once per frame
	void Update () {	
		if (vac.ok == false)
		{
			transform.Translate(new Vector2(x, 0) * Time.deltaTime);
			if (transform.position.x < minx )
				x = 1;
			else if (transform.position.x > maxx)
				x = -1;
			if (x == 1 && transform.localScale.x < 0 || x == -1 && transform.localScale.x > 0)
				flip();
		}
	}

	void flip()
	{
		transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
	}
}
