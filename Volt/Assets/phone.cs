using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phone : MonoBehaviour {


	public void Use () {
			GetComponent<Animator>().SetBool("ring", true);
	}
}
