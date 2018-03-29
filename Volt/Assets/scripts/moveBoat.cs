using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBoat : MonoBehaviour {

    private bool right = false;
	public static bool ok = false;
	public Camera cam;
	private Rigidbody2D rb;
	public GameObject water;
	public GameObject sp;
	public GameObject axis;
	private int i = 1;
	public AudioClip clip;
	private Animator anim;
	private AudioSource source;
	public GameObject player;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (ok == true)
		{
			player.transform.position = transform.position;
			if (Input.GetKey(KeyCode.D) && ok == true)
			{
				rb.velocity = new Vector2(2.5f, 0);
				right = false;
			}
			else if (Input.GetKey(KeyCode.Q) && ok == true)
			{
				rb.velocity = new Vector2(-2.5f, 0);
				right = true;
			}
			else
				rb.velocity = new Vector2(0, 0);
			if (ok == true && right == true && transform.localScale.x < 0 || right == false && transform.localScale.x > 0)
				flip();
			if (Input.GetKeyDown(KeyCode.E))
				shoot();
			if (Input.GetKeyDown(KeyCode.Z) && i < 2)
				i++;
			else if (Input.GetKeyDown(KeyCode.S) && i > 0)
				i--;
			anim.SetInteger("up", i);
		}
	}

	void shoot()
	{
		Vector2 direction;

		direction.x = sp.transform.position.x - axis.transform.position.x; 
		direction.y = sp.transform.position.y - axis.transform.position.y; 
		GameObject tmp = Instantiate(water);
		//source.PlayOneShot(clip, 1f);
		tmp.transform.position = new Vector2(sp.transform.position.x, sp.transform.position.y); 
		tmp.GetComponent<Rigidbody2D>().AddForce(direction * 35, ForceMode2D.Impulse);
	}
	
	void flip()
	{
		transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
	}
}
