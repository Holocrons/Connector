using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class option : MonoBehaviour {

    public Button button;
    public GameObject image;


 void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
			  image.SetActive(false);
	}

    void TaskOnClick()
    {
        image.SetActive(true);
    }
}
