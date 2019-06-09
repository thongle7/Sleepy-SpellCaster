using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeBean : MonoBehaviour {

    public float sleepRegain;
    public GameObject sleepRegainText;

    private PlayerSleep pSleep;

    void OnTriggerEnter2D(Collider2D col)
    {
        pSleep = col.GetComponent<PlayerSleep>();
        if (pSleep)
        {
            Instantiate(sleepRegainText, col.transform.position, Quaternion.identity, col.transform);
            wiz_control.wizFatigue -= sleepRegain;
            Destroy(gameObject);
        }
    }
}
