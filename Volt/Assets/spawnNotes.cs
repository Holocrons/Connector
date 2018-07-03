using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnNotes : MonoBehaviour {

	public List<GameObject> spawnPoints;
	public List<GameObject> notes;
	private float timer;
    private float timer2;
	public List<int> note;
	public List<float> time;
    public static AudioSource source;
	public AudioClip lol;
    public bool createMod = false;
    private bool music = true;
    private int i;
    private GameObject tmp = null;
    private bool conti = true;

	
	void Start () {
        i = 0;
		timer = Time.time + time[i];
        timer2 = Time.time + 3f;
        source = GetComponent<AudioSource>();
	}

	void Update () {

        if (timer2 < Time.time && source.isPlaying == false && music == true)
        {
            source.PlayOneShot(lol, 1f);
            music = false;
        }
        if (createMod == true)
            createTab();
        else if (conti == true)
            spawnNote();
    }

    void spawnNote()
    {
        if (timer < Time.time)
        {
            tmp = Instantiate(notes[note[i]], spawnPoints[note[i]].transform.position, spawnPoints[note[i]].transform.rotation);
            tmp.transform.parent = gameObject.transform;
            if (i < note.Count - 1)
            {
                i++;
                timer = Time.time + time[i];
            }
            else
                conti = false;
         }
    }

    void createTab()
    {
        if (Input.GetKeyDown("a"))
            Instantiate(notes[0], spawnPoints[0].transform.position, spawnPoints[0].transform.rotation);
    }
}
