using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonLoadLevel : MonoBehaviour {
    public string levelName;
    public Button runButton;

    void Start()
    {
        runButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene(levelName);
    }
}
