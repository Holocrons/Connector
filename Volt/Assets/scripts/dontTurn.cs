using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontTurn : MonoBehaviour {

	private Transform[] parent;

	// Use this for initialization
	void Start () {
		parent = GetComponentsInParent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		if (parent[1].localScale.x == -1)
			transform.localScale = new Vector2(-1, 1);
		else 
			transform.localScale = new Vector2(1, 1);
	}
}
