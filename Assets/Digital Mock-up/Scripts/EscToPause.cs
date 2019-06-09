using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscToPause : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (GameTime.isPaused) return;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameTime.isPaused = true;
            
            SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
        }
    }
}
