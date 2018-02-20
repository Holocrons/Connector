using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plaque : MonoBehaviour {

	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Use()
	{
		anim.SetBool("chauffe", true);
	}	
}
