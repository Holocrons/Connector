using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Load1()
    {
        SceneManager.LoadScene("niveau1");
    }

    public void Load2()
    {
        SceneManager.LoadScene("niveau2");
    }

    public void LoadMm()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Load3()
    {
        SceneManager.LoadScene("niveau3");
    }

    public void LoadSelect()
    {
        SceneManager.LoadScene("SelectScene");
    }
}
