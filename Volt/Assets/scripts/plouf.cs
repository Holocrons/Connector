using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plouf : MonoBehaviour {
public GameObject chat;


void OnTriggerEnter2D(Collider2D other)
{
	if (other.name == "seche") {
		GetComponent<Animator>().enabled = true;	
		chat.GetComponent<Animator>().SetBool("d", true);
	}
}

}
