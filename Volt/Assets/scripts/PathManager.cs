using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathManager : MonoBehaviour {

	public GameObject Bulle;
	public List<GameObject> obj;
	public  List<GameObject> curentPath;
	public List<GameObject> path;
	public List<GameObject> path1;
	public List<GameObject> path2;
	public List<GameObject> path3;
	private List<List<GameObject>> stock = new List<List<GameObject>>();
	public static GameObject lol;

	// Use this for initialization
	void Start () {
		stock.Add(path);
		stock.Add(path1);
		stock.Add(path2);
		stock.Add(path3);
	}

	void Update()
	{
		if (Bulle != null && tag == "Usb")
			 Bulle.SetActive(true);
	}

	public bool getPath(string str)
	{
		int i = 0;
		bool ok = false;

		while (i != obj.Count)
		{
			if (obj[i].name == playerManager.namel && obj[i].name != "non")
			{
				ok = true;
				break;
			}
			i++;
		}
		if (ok == true)
		{
			playerManager.Paths = stock[i];
			lol = obj[i];
		}
		return (ok);
	}
}
