using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manualChangeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //SceneManager.LoadScene(sceneName);
        if (Input.GetKeyDown("0")){
            SceneManager.LoadScene("Movement");
        }

        if (Input.GetKeyDown("1"))
        {
            SceneManager.LoadScene("UI");
        }

        if (Input.GetKeyDown("2"))
        {
            SceneManager.LoadScene("Fighting");
        }

    }
}


