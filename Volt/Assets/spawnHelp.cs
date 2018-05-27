using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnHelp : MonoBehaviour {

	public GameObject player;
	private List<GameObject> tmp = null;
	private List<GameObject> flush = new List<GameObject>();
	private GameObject curent;
	private float x = -7f;
	public float y = -1.25f;
	
	// Use this for initialization
	void Start () {
			if (player.GetComponent<playerManager>().curent)
			{
				curent = player.GetComponent<playerManager>().curent;
				tmp = curent.GetComponent<toSpawn>().help;
				int i = 0;
				foreach(GameObject obj in tmp)
					{
						flush.Add(Instantiate(obj, new Vector2(x + 1.4f * i, y), transform.rotation));
						i++;
					}
			}
	}
	
	// Update is called once per frame
	void Update () {
	
		if (curent != player.GetComponent<playerManager>().curent)
			{
				curent = player.GetComponent<playerManager>().curent;
				if (flush != null)
					foreach(GameObject obj in flush)
						Destroy(obj);
				flush = new List<GameObject>();
				if (curent.GetComponent<toSpawn>())
					{
					tmp = curent.GetComponent<toSpawn>().help;
					int i = 0;
					foreach(GameObject tg in tmp)
						{
							if (tg == null)
								Debug.Log("PD");
							flush.Add(Instantiate(tg, new Vector2(x + 1.4f * i, y), transform.rotation));
							i++;
						}
					}
			}
	}
}
