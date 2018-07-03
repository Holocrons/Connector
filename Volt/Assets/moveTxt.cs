using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class moveTxt : MonoBehaviour {

	// Use this for initialization

	public List<KeyCode> keyList;
	private double x;
	private double y;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown(keyList[0]) && transform.localPosition.x < 1.4)
		transform.Translate(new Vector2(0.2f, 0));
	else if (Input.GetKeyDown(keyList[1]) && transform.localPosition.x >= -0.8f)
		transform.Translate(new Vector2(-0.2f, 0));
	else if (Input.GetKeyDown(keyList[2]) && transform.localPosition.y <= 0.8f)
		transform.Translate(new Vector2(0, 0.2f));
	else if (Input.GetKeyDown(keyList[3]) && transform.localPosition.y >= -0.8f)
		transform.Translate(new Vector2(0, -0.2f));
	x = transform.localPosition.x;
	y = transform.localPosition.y;
	transform.localPosition = new Vector2((float)Math.Round(x, 1), ((float)Math.Round(y, 1)));
	}
}
