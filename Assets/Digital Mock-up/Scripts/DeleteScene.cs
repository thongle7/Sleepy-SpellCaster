using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DeleteScene : MonoBehaviour {

    public Button runButton;

    // Use this for initialization
    void Start () {
        runButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        GameTime.isPaused = false;
        battleFlow.immuneLullaby = false;
        battleFlow.immuneDrain = false;
        battleFlow.immuneBlanket = false;
        Destroy(gameObject);
    }
}
