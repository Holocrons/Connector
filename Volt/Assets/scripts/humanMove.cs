using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humanMove : MonoBehaviour {

	private float speed = 1;
	public float stop = 0;
	private float timer = 0;
	private float direction = 1.0f;
	public static bool ok = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ok == true)
		{
			if (transform.position.x < stop)
				transform.Translate(new Vector2(direction, 0f) * Time.deltaTime * speed);
			else 
			{
				transform.GetComponent<Animator>().SetBool("stop", true);	
				if (timer == 0)
					timer = Time.time + 0.6f;
			}
			if (timer != 0 && timer < Time.time)
			{
				transform.GetComponent<Animator>().SetBool("stop", false);
				phone.takePhone = true;
				if (transform.localScale.x > 0)
					transform.localScale = new Vector3(-0.8f, 0.8f, 1);
				direction = -1.0f;
				speed = 0.8f;
				transform.Translate(new Vector2(direction, 0f) * Time.deltaTime * speed);
			}
		}
	}
}
