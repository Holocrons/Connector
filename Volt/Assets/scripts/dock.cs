using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dock : MonoBehaviour {

	public GameObject helico;

	public void Use()
	{
		helico.GetComponent<fly>().enabled = true;
		fly.act = true;
	}
}
