using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour {

	public GameObject player;
	private Animator anim;
	public static bool act = false;
	private bool right = true;
	public AudioClip clip;
	private AudioSource source;
	public GameObject[] coll; 
	private Rigidbody2D rb;


	// Use this for initialization
	void Awake () {
		source = GetComponent<AudioSource>();
		anim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D>();
		for (int i = 0; i < coll.Length; i++ )
		{	
			Physics2D.IgnoreCollision(GetComponent<Collider2D>(), coll[i].GetComponent<Collider2D>());
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (source.isPlaying == false)
			source.PlayOneShot(clip, 1f);
		anim.SetBool("deco", true);
		player.transform.position = transform.position;
		if (Input.GetKey(KeyCode.Z))
			rb.velocity = new Vector2(0, 5f);
		else if (Input.GetKey(KeyCode.S))
			rb.velocity = new Vector2(0, -5f);
		else if (Input.GetKey(KeyCode.D))
		{
			rb.velocity = new Vector2(5f, 0);
			right = true;
		}
		else if (Input.GetKey(KeyCode.Q))
		{
			rb.velocity = new Vector2(-5f, 0);
			right = false;
		}
		else 
			rb.velocity = new Vector2(0, 0);
		if (right == true && transform.localScale.x < 0 || right == false && transform.localScale.x > 0)
			flip();
	}

	void flip()
	{
		transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.name == "helico_dock" && act == true)
		{
			player.transform.position = other.gameObject.transform.position;
			anim.SetBool("deco", false);
			act = false;
			GetComponent<fly>().enabled = false;
		}
	}
}
