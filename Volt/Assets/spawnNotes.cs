using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnNotes : MonoBehaviour {
	
	public List<GameObject> spawnPoints;
	public List<GameObject> notes;
	private float timer;
	private int i = 0;

	// Use this for initialization
	void Start () {
		timer = Time.time + 0.4f;
	}
	
	// Update is called once per frame
	void Update () {
		GameObject tmp;

		if (timer < Time.time)
		{
			if (i == 4)
				i = 0;
			tmp = Instantiate(notes[i], spawnPoints[i].transform.position, spawnPoints[i].transform.rotation);			
			tmp.transform.parent = gameObject.transform;
			timer = Time.time + 0.4f;
			i++;
		}
	}
}
