using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class changeScene_StartToControl : MonoBehaviour {
    //Change scene
    public void ChangeSceneToAnother_Single(string newSceneName)
    {
        SceneManager.LoadScene(newSceneName, LoadSceneMode.Single);
    }

}
