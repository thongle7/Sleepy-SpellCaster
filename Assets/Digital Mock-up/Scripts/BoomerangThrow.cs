using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomerangThrow : MonoBehaviour {

    public GameObject Boomerang;
    private bool isAlive = false;
    private GameObject tempRang;

    // Update is called once per frame
    void Update () {
        if (GameTime.isPaused) return;
        if (tempRang == null)
        {
            isAlive = false;
        }
        if (Input.GetMouseButtonDown(0) && !isAlive)
        {
            Instantiate(Boomerang, transform.position, transform.rotation);
            tempRang = GameObject.Find("Boomerang 1(Clone)");
            isAlive = true;
        }
    }
}
