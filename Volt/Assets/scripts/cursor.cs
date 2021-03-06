﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor : MonoBehaviour {

	public GameObject obj;
	private Camera cam;
	private Vector2 p;

	// Use this for initialization
	void Start () {
		//Cursor.visible = false;
		cam  = obj.GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		p = cam.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
		transform.position = p;
	}

	void OnTriggerStay2D(Collider2D other)
	{
		if (Input.GetMouseButtonDown(0) && (other.tag == "link" || other.tag == "Usb"))
		{
			playerManager.namel = other.name;
		} 
	}

	void OnTriggerEnter2D(Collider2D other)
	{	
		Animator[] tmp;
		if (other.tag == "Usb" || other.tag == "non")
		{
			tmp = other.GetComponentsInChildren<Animator>();
			if (tmp.Length == 1)
				tmp[0].SetBool("info", true);
			else if (other.name != "socket_24x24") 
				tmp[1].SetBool("info", true);
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{	
		Animator[] tmp;
		if (other.tag == "Usb" || other.tag == "non")
		{
			tmp = other.GetComponentsInChildren<Animator>();
			if (tmp.Length == 1)
				tmp[0].SetBool("info", false);
			else if (other.name != "socket_24x24")
				tmp[1].SetBool("info", false);
		}
	}
}
