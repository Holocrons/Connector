﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuto : MonoBehaviour {

	private Animator anim;
	private int nb = 0;

	void Start()
	{
		anim = GetComponent<Animator>();
	}

	void OnTriggerStay2D(Collider2D other)
	{
		if (Input.GetMouseButtonDown(0))
		{
			Debug.Log("courge");
			nb++;
			if (nb == 5)
				nb = 0;
			anim.SetInteger("tuto", nb);
		}		
	}
}