using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerManager : MonoBehaviour {

	public GameObject start;
	public GameObject curent;
	private Transform tmp; 
	public static List<GameObject> Paths = null; 
	int i = 0;
	public static string namel = null;
	private Animator anim;
	public static string tp = null; 
	public static bool canTp = false;
	private bool rc = false;
	public int next;
	public AudioClip clip1;
	public AudioClip clip2;
	private AudioSource source;
    private Vector3 old; 


	void Start () {
		transform.position = start.GetComponent<Transform>().position;
		anim = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
        old = this.transform.position;
    }
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.R))
		{
			humanMove.ok = false;
			phone.takePhone = false;
			SceneManager.LoadScene(next - 1);
		}
		curent.layer = 2;
		if (curent.tag == "Usb" )
			canTp = true;
		else 
			canTp = false;
		if (namel != null && curent.name != "pc")
		{	
			if (curent.GetComponent<PathManager>().getPath(namel) == true) 
			{
				curent.layer = 0;
				curent = PathManager.lol;
				anim.SetBool("start", true);
				source.PlayOneShot(clip1, 1f);
			}
			else if (canTp == true)
				tp = namel;
			namel = null;
		}
		if (Paths != null && Paths.Count > i)
			{
            anim.SetBool("move", true);
				tmp = Paths[i].GetComponent<Transform>();
				if (transform.position.x > tmp.position.x + 0.1f)
					transform.Translate(new Vector2(-0.2f, 0));
				else if (transform.position.x < tmp.position.x - 0.1f)
					transform.Translate(new Vector2(0.2f, 0));
				else if (transform.position.y > tmp.position.y + 0.1f)
					transform.Translate(new Vector2(0, -0.2f));
				else if (transform.position.y < tmp.position.y - 0.1f)
					transform.Translate(new Vector2(0, 0.2f));
				else
					i++;
			}
		else if (Paths != null) 
		{
            anim.SetBool("move", false);
            i = 0;
			Paths = null;
			if (curent.name == "socket")
				SceneManager.LoadScene(next);
		}
		use();
		if (Input.GetMouseButtonDown(0) && GameObject.Find(tp) && curent.name != "pc")
		{
			castRay(GameObject.Find(tp));
			if (rc)
			{
				source.PlayOneShot(clip2, 1f);
			}
		}
		if (tp != null && (GameObject.Find(tp).tag == "Usb" || GameObject.Find(tp).tag == "non") && rc == true)
			{
				if (curent.GetComponent<vac>() != null || curent.GetComponent<moveBoat>() != null)
					curent = GameObject.Find(tp);
				teleport(GameObject.Find(tp));
			}
		else 
			tp = null;	
	}

	void castRay(GameObject target)
	{
		RaycastHit2D hit;

		hit = Physics2D.Raycast(transform.position, new Vector2(target.transform.position.x - transform.position.x, target.transform.position.y - transform.position.y), Vector2.Distance(target.transform.position, transform.position));
		if (hit != false && hit.collider.gameObject != target)
		{
			rc =  false;
		}
		else 
			rc = true;
	}

	void teleport(GameObject tps)
	{
		tmp = tps.GetComponentInChildren<Transform>();
		if (transform.position.x > tmp.position.x + 0.1f)
			transform.Translate(new Vector2(-0.2f, 0));
		else if (transform.position.x < tmp.position.x - 0.1f)
			transform.Translate(new Vector2(0.2f, 0));
		else if (transform.position.y > tmp.position.y + 0.1f)
			transform.Translate(new Vector2(0, -0.2f));
		else if (transform.position.y < tmp.position.y - 0.1f)
			transform.Translate(new Vector2(0, 0.2f));
		else 
		{
			rc = true;
			curent = tps;
			tp = null;
		}
	}

	void use()
	{
		if (curent.GetComponent<vac>() != null){
			vac.ok = true;
		}
		else 
			vac.ok = false;
		if (curent.GetComponent<moveBoat>() != null){
			moveBoat.ok = true;
		}
		else 
			moveBoat.ok = false;
		if (Input.GetKeyDown(KeyCode.E))
		{
			if (curent.GetComponent<canap>() != null)
				curent.GetComponent<canap>().Use();
			else if (curent.GetComponent<rad>() != null)
				curent.GetComponent<rad>().Use();
			else if (curent.GetComponent<dock>() != null)
				curent.GetComponent<dock>().Use();
			else if (curent.GetComponent<plaque>() != null)
				curent.GetComponent<plaque>().Use();
			else if (curent.GetComponent<toaster>() != null)
				curent.GetComponent<toaster>().Use();
			else if (curent.GetComponent<phone>() != null)
				curent.GetComponent<phone>().Use();
			else if (curent.GetComponent<bass>() != null)
				curent.GetComponent<bass>().Use();
			else if (curent.GetComponentInChildren<color>() != null)
			{
				if (curent.GetComponentInChildren<color>().Use() == -1)
				{
					curent.tag = "Usb";	
				}
			}
		}
	}
}
