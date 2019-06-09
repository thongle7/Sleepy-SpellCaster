using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Unpause : MonoBehaviour {

    public GameObject scene;

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameTime.isPaused = false;
            Destroy(scene);
        }
        
    }
}
