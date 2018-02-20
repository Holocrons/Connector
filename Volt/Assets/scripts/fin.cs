using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fin : MonoBehaviour {

	public GameObject lol;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject == lol)
			SceneManager.LoadScene(4);
	}
}
