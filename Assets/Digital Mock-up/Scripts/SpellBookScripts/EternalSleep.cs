using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EternalSleep : MonoBehaviour {

    public float damage;

    private PlayerSpells spells;

    void OnTriggerEnter2D(Collider2D col)
    {
        spells = col.GetComponent<PlayerSpells>();
        if (spells)
        {
            wiz_control.eternalSleepStock++;
            Destroy(gameObject);
        }
    }
}
