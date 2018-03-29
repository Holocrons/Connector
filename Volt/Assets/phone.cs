using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class phone : MonoBehaviour {

	public static bool GameIsPaused = false;
	 public GameObject pauseMenuUI;
	
	public void Use () {
			GetComponent<Animator>().SetBool("ring", true);
			Pause();
	}
    
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting game....");
    }
}
