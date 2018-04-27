using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class endGame : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player" && other.gameObject.transform.localScale.x < 0)
		{
			SceneManager.LoadScene("niveau4");
		}
	}
}
