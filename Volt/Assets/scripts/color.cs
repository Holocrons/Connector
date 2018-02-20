using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour {
    private int state = 0;
    private List<Color> tab = new List<Color>();
    public Sprite spr;
    private SpriteRenderer sprR;
    public AudioClip clip;
    public AudioClip clip2;
	private AudioSource source;

	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
        //GetComponent<SpriteRenderer>();
        sprR = GetComponent<SpriteRenderer>();
        tab.Add(new Color(1F, 0.8F, 0F, 1F));
        tab.Add(new Color(1F, 0.5F, 0F, 1F));
        tab.Add(new Color(1F, 0F, 0F, 1F));
    }
	
	// Update is called once per frame
	public int Use () {
		if (state < 4)
        {
            if (state == 3)
            {
                source.PlayOneShot(clip2, 1f);
                GetComponent<SpriteRenderer>().color = new Color(1F, 1F, 1F);
                sprR.sprite = spr;
                return (-1);        
            }
            else
            {
                source.PlayOneShot(clip, 1f);
                GetComponent<SpriteRenderer>().color = tab[state];
                state++;
            }
        }
        return (state);
	}
}
