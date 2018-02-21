using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour {

	public GameObject activate;
	private Animator anim;
	public AudioClip clip;
	private AudioSource source;
	public GameObject elec;
	private bool go = false;
	private float timer;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
		anim = GetComponent<Animator>();

	}
	
	void Update()
	{
		if (go == true)
			{
				if (timer < Time.time)
					elec.GetComponent<Animator>().SetBool("water", true);
			}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "salt")
		{
			activate.tag = "Usb";
			if (source.isPlaying == false)
				source.PlayOneShot(clip, 1f);
			anim.SetBool("go", true);
			timer = Time.time + 0.3f;
			go = true;
		}
	}
}
