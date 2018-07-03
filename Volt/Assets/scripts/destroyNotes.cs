using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyNotes : MonoBehaviour {

	public string _tag;
	public string keys;
    private GameObject current = null;
    private bool active = false;
    private bool miss = false;

    void Update()
    {
        if (current != null && active == true && Input.GetKeyDown(keys))
        {
            Destroy(current);
            current = null;
            active = false;
            spawnNotes.source.volume = 1.0f;
        }
        else if ((Input.GetKeyDown(keys) && active == false))// || miss == true)
        {
            spawnNotes.source.volume = 0f;
            miss = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "note")
        {
            active = true;
            current = other.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "note")
        {
            if (current != null)
                miss = true;
            active = false;
            current = null;
        } 
    }
}
