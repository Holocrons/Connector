using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightUp : MonoBehaviour {

    public GameObject lights;
    public string keys;

    // Use this for initialization
    void Start () {
		    
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(keys))
            lights.SetActive(true);
        else
            lights.SetActive(false);

    }
}
