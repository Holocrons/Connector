using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bass : MonoBehaviour {

	public GameObject begin; 
	private bool active = true;

	public void Use()
	{
		begin.SetActive(active);
		active = !active;
	}
}
