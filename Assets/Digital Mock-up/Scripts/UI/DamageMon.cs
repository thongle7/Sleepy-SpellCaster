using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageMon : MonoBehaviour {

    public float damageVal;
    private float wait = 0;

    private PlayerSleep player;

    void OnCollisionEnter2D (Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
           PlayerSleep script = col.gameObject.GetComponent<PlayerSleep>();
            wiz_control.wizFatigue += damageVal;
        }

    }

}
