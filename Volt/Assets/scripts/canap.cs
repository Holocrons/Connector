using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canap : MonoBehaviour {
    private Animator anim;
    private bool temp = false;
    public AudioClip clip;
	private AudioSource source;

	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
	}
   
   public void Use ()
    {
        source.PlayOneShot(clip, 1f);
        if (temp == false)
        {
            anim.SetBool("open", true);
            temp = true;
        }
        else if (temp == true)
        {
            anim.SetBool("open", false);
            temp = false;
        }
    }
}
